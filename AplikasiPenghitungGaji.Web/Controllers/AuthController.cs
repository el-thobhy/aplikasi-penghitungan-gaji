using AplikasiPenghitungGaji.Web.Services;
using Azure;
using Microsoft.AspNetCore.Mvc;
using ViewModel;

namespace AplikasiPenghitungGaji.Web.Controllers
{
    public class AuthController : Controller
    {
        private AuthServices _services;
        public AuthController(IConfiguration configuration)
        {
            _services = new AuthServices(configuration["ApiUrl"]);
        }
        public IActionResult Index()
        {
            return PartialView();
        }


        public async Task<IActionResult> Login(LoginViewModel data)
        {
            ReturnLoginViewModel result = await _services.Login(data);
            if (result.Id == new Guid())
            {
                ViewBag.Message = "Fail To Login";
            }
            else
            {
                HttpContext.Session.SetString("Token", result.Token);
                HttpContext.Session.SetString("UserName", result.UserName);
            }
            return RedirectToAction("Index", "Lembur");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Lembur");
        }
    }
}
