using System;
using System.Collections.Generic;
using TodoReward.Shared.Model;

namespace TodoReward.Backend.Repository
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void RemoveUser(Guid id);
        void UpdateUser(User user);
        User GetUser(Guid id);
        List<User> GetUsers();
    }
}
