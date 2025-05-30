﻿using BlazorServerApp.Model.EntityModel;

namespace BlazorServerApp.DLL.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User?> GetByIdAsync(int id);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);

        //Task<List<User>> GetAllAsync();
        //Task AddAsync(User user);
        //Task DeleteAsync(int id);
    }
}
