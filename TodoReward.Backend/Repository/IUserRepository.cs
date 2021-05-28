using System;
using System.Collections.Generic;
using TodoReward.Data.Model;

namespace TodoReward.Data.Repository
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
