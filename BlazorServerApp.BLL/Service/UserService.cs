using BlazorServerApp.BLL.Interface;
using BlazorServerApp.DLL.Interface;
using BlazorServerApp.Model.EntityModel;

namespace BlazorServerApp.BLL.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public Task<List<User>> GetAllUsersAsync() => _userRepo.GetAllAsync();

        public Task<User?> GetUserByIdAsync(int id) => _userRepo.GetByIdAsync(id);

        public Task AddUserAsync(User user) => _userRepo.AddAsync(user);

        public Task UpdateUserAsync(User user) => _userRepo.UpdateAsync(user);

        public Task DeleteUserAsync(int id) => _userRepo.DeleteAsync(id);
        ////private readonly AppDbContext _context;

        ////public UserService(AppDbContext context) => _context = context;

        ////public async Task<List<User>> GetAllAsync() =>
        ////    await _context.Users.ToListAsync();

        ////public async Task AddAsync(User user)
        ////{
        ////    _context.Users.Add(user);
        ////    await _context.SaveChangesAsync();
        ////}

        ////public async Task DeleteAsync(int id)
        ////{
        ////    var user = await _context.Users.FindAsync(id);
        ////    if (user != null)
        ////    {
        ////        _context.Users.Remove(user);
        ////        await _context.SaveChangesAsync();
        ////    }
        ////}
    }
}
