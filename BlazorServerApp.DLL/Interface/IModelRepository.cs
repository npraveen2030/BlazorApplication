using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorServerApp.Model.EntityModel;

namespace BlazorServerApp.DLL.Interface
{
    public interface IModelRepository
    {
        Task<List<Models>> GetAllAsync();
        Task<Models?> GetByIdAsync(int id);
        Task AddAsync(Models user);
        Task UpdateAsync(Models user);
        Task DeleteAsync(int id);
    }
}
