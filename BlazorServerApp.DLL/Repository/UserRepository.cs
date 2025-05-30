using BlazorServerApp.DLL.Interface;
using BlazorServerApp.Model.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.DLL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) => _context = context;

        public async Task<List<User>> GetAllAsync() => await _context.Users.ToListAsync();

        public async Task<User?> GetByIdAsync(int id) => await _context.Users.FindAsync(id);

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            var existing = await _context.Users.FindAsync(user.Id);
            if (existing != null)
            {
                existing.Name = user.Name;
                existing.Email = user.Email;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
        ////private readonly AppDbContext _context;

        ////public UserRepository(AppDbContext context)
        ////{
        ////    _context = context;
        ////}

        ////public async Task<List<User>> GetAllAsync()
        ////{
        ////    return await _context.Users.ToListAsync();
        ////}

        ////public async Task<User?> GetByIdAsync(int id)
        ////{
        ////    return await _context.Users.FindAsync(id);
        ////}

        ////public async Task AddAsync(User user)
        ////{
        ////    _context.Users.Add(user);
        ////    await _context.SaveChangesAsync();
        ////}

        ////public async Task UpdateAsync(User user)
        ////{
        ////    _context.Users.Update(user);
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
        ///
        //private readonly AppDbContext _context;

        //public UserRepository(AppDbContext context) => _context = context;

        //public async Task<List<User>> GetAllAsync() => await _context.Users.ToListAsync();

        //public async Task AddAsync(User user)
        //{
        //    _context.Users.Add(user);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    var user = await _context.Users.FindAsync(id);
        //    if (user != null)
        //    {
        //        _context.Users.Remove(user);
        //        await _context.SaveChangesAsync();
        //    }
        //}
    }
}
