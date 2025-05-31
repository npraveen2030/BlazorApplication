using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorServerApp.Model.EntityModel;

namespace BlazorServerApp.BLL.Interface
{
    public interface IModelService
    {
        Task<List<Models>> GetAllUsersAsync();
        Task<Models?> GetUserByIdAsync(int id);
        Task AddUserAsync(Models user);
        Task UpdateUserAsync(Models user);
        Task DeleteUserAsync(int id);
    }
}
