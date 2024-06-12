using DataModel;
using Framework.Auth;
using Microsoft.EntityFrameworkCore;

namespace AplikasiPenghitungGaji.Api.Repository
{
    public class UserRepository
    {
        protected readonly PegawaiDbContext _context;
        public UserRepository(PegawaiDbContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Set<User>().ToListAsync();
        }

        public async Task<User> Login(string username, string password)
        {
            return await _context.Set<User>()
                .FirstOrDefaultAsync(o => o.UserName == username && o.Password == Encryption.HashSha256(password))
                ?? new User();
        }

        public async Task<User> Register(User user)
        {
            _context.Add(user).State = EntityState.Added;
            return user;
        }
        public async Task<User?> GetUserById(Guid id)
        {
            return await _context.Set<User>()
                .FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken= default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
        //fungsi dispose untuk clear sampah yang ada, GC itu Garbage Collector
        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
