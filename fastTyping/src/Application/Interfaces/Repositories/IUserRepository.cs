﻿using Domain.Models.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetUserById(int id);
        Task<User?> GetUserByEmailAsync(string email);
        Task<User?> GetUserByUsernameAsync(string Username);
        Task<User> AddUserAsync(User user);
    }
}
