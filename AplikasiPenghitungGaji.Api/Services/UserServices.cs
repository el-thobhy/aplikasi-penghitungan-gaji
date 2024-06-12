using AplikasiPenghitungGaji.Api.Repository;
using DataModel;
using Framework.Auth;
using ViewModel;

namespace AplikasiPenghitungGaji.Api.Services
{
    public class UserServices
    {
        private readonly UserRepository _userRepository;
        private readonly PegawaiDbContext _dbContext;
        public UserServices(PegawaiDbContext dbContext)
        {
            _userRepository = new UserRepository(dbContext);
            _dbContext = dbContext;

        }

        public Task<IEnumerable<UserViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ReturnLoginViewModel> Login(LoginViewModel login)
        {
           ReturnLoginViewModel? model = (from o in _dbContext.Users
                                        where o.UserName == login.UserName && o.Password == Encryption.HashSha256(login.Password)
                                        select new ReturnLoginViewModel
                                        {
                                            UserName = o.UserName,
                                            FirstName = o.FirstName,
                                            LastName = o.LastName,
                                            Id = o.Id,
                                            Roles = new List<string>
                                            {
                                                o.Role.ToString(),
                                            }
                                        }
                                        ).FirstOrDefault();
            return model ?? new ReturnLoginViewModel();
        }

        public async Task<UserViewModel> Register(UserViewModel user)
        {
            UserViewModel? output = new UserViewModel();
            User entity = new User
            {
                UserName = user.UserName, 
                Password = Encryption.HashSha256(user.Password),
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Role = user.Role,
                CreateBy = "administrator",
                CreateDate = DateTime.Now,
            };
            _userRepository.Register(entity);
            var result = await _userRepository.SaveChangeAsync();
            if (result > 0)
            {
                output = (from o in _dbContext.Users
                          where o.Id == entity.Id
                          select new UserViewModel
                          {
                              UserName = o.UserName,
                              Password = o.Password,
                              Email = o.Email,
                              FirstName = o.FirstName,
                              LastName = o.LastName,
                              Role = o.Role,
                              Id = o.Id
                          }).FirstOrDefault();
            }
            return output ?? new UserViewModel();
        }
    }
}
