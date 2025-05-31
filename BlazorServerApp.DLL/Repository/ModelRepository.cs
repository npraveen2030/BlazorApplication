using BlazorServerApp.DLL.Interface;
using BlazorServerApp.Model.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.DLL.Repository
{
    public class ModelRepository : IModelRepository
    {
        private readonly AppDbContext _context;

        public ModelRepository(AppDbContext context) => _context = context;
        public async Task AddAsync(Models user)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Models>> GetAllAsync() => await _context.Models.ToListAsync();

        public async Task<Models?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Models user)
        {
            throw new NotImplementedException();
        }
    }
}
