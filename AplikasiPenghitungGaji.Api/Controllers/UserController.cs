using AplikasiPenghitungGaji.Api.Services;
using DataModel;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ViewModel;

namespace AplikasiPenghitungGaji.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserServices _service;
        private IValidator<UserViewModel> _validator;
        private IValidator<LoginViewModel> _validatorLogin;
        private IConfiguration _config;
        public UserController(PegawaiDbContext dbContext, IValidator<UserViewModel> validator, IValidator<LoginViewModel> validatorLogin, IConfiguration config)
        {
            _service = new UserServices(dbContext);
            _validator = validator;
            _validatorLogin = validatorLogin;
            _config = config;
        }

        [HttpPost("Register")]
        public async Task<UserViewModel> Register(UserViewModel model)
        {
            ValidationResult resultVal = await _validator.ValidateAsync(model);
            if(!resultVal.IsValid)
            {
                throw new Exception(resultVal.Errors.ToString());
            }
            else
            {
                var result = await _service.Register(model);
                return result;
            }
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            ValidationResult val = await _validatorLogin.ValidateAsync(model);
            if(!val.IsValid)
            {
                return BadRequest(val.Errors);
            }
            else
            {
                ReturnLoginViewModel result = await _service.Login(model);
                if(result.Id != new Guid())
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, result.UserName),
                        new Claim("FullName", result.FullName),
                        new Claim("Id", result.Id.ToString())
                    };
                    foreach(var i in result.Roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, i.ToString()));
                    }
                    var token = GetToken(claims);
                    result.Token = new JwtSecurityTokenHandler().WriteToken(token);
                    result.Expiration = token.ValidTo;
                    return Ok(result);
                }
                else
                {
                    List<object> resultError = new List<object>
                    {
                        new
                        {
                            propertyName = "Credential",
                            errorMessage = "Credential not match!!"
                        }
                    };
                    return NotFound(resultError);
                }
            }

        }

        private JwtSecurityToken GetToken(List<Claim> claims)
        {
            var authSignInKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:Secret"]??"None"));
            var token = new JwtSecurityToken(
                issuer: _config["JWT:ValidIssuer"],
                audience: _config["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(Convert.ToDouble(_config["JWT:ExpireDays"])),
                claims: claims,
                signingCredentials: new SigningCredentials(authSignInKey, SecurityAlgorithms.HmacSha256)
            );
            return token;
        }
    }
}
