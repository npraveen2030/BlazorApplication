using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorServerApp.BLL.Interface;
using BlazorServerApp.DLL.Interface;
using BlazorServerApp.Model.EntityModel;
using BlazorServerApp.BLL.Interface;
using BlazorServerApp.DLL.Interface;
using BlazorServerApp.Model.EntityModel;

namespace BlazorServerApp.BLL.Service
{
    public class ModelService : IModelService
    {
        private readonly IModelRepository _modelRepo;

        public ModelService(IModelRepository modelRepo)
        {
            _modelRepo = modelRepo;
        }

        public Task<List<Models>> GetAllUsersAsync() => _modelRepo.GetAllAsync();

        public Task<Models?> GetUserByIdAsync(int id) => _modelRepo.GetByIdAsync(id);

        public Task AddUserAsync(Models user) => _modelRepo.AddAsync(user);

        public Task UpdateUserAsync(Models user) => _modelRepo.UpdateAsync(user);

        public Task DeleteUserAsync(int id) => _modelRepo.DeleteAsync(id);
    }
}
