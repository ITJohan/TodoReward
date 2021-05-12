using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoReward.Model;

namespace TodoReward.Repository
{
    public class UserRepository : IUserRepository
    {
        private IList<User> _users;

        public UserRepository()
        {
            _users = new List<User>();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public User GetUser(Guid id)
        {
            User user = _users.FirstOrDefault(u => u.Id == id);
            return user;
        }

        public List<User> GetUsers()
        {
            return _users.ToList();
        }

        public void RemoveUser(Guid id)
        {
            User user = GetUser(id);

            if (user != null)
            {
                _users.Remove(user);
            }
        }

        public void UpdateUser(User user)
        {
            RemoveUser(user.Id);
            AddUser(user);
        }
    }
}
