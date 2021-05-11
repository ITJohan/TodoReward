using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoReward.Model;

namespace TodoReward.Repository
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
