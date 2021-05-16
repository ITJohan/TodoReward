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
            _users = new List<User>
            {
                new User
                {
                    Id = new Guid("0021c27c-ab20-4e79-9af4-a6a46294c293"),
                    FirstName = "Johan",
                    LastName = "Lindkvist",
                    Email = "johanlindkvist89@gmail.com",
                    Points = 4878,
                    Todos = new List<Todo>
                    {
                        new Todo
                        {
                            Id = new Guid(),
                            Description = "Ring Siv",
                            Points = 10,
                            TimeLeft = 16,
                            RepeatInterval = 30
                        },
                        new Todo
                        {
                            Id = new Guid(),
                            Description = "Ring Solveig",
                            Points = 100,
                            TimeLeft = 4,
                            RepeatInterval = 30
                        },
                        new Todo
                        {
                            Id = new Guid(),
                            Description = "Træna",
                            Points = 10,
                            TimeLeft = 1,
                            RepeatInterval = 1
                        },
                        new Todo
                        {
                            Id = new Guid(),
                            Description = "Yoga",
                            Points = 10,
                            TimeLeft = 1,
                            RepeatInterval = 1
                        }
                    },
                    Rewards = new List<Reward>
                    {
                        new Reward
                        {
                            Id = new Guid(),
                            Description = "1h gaming",
                            Points = -10
                        },
                        new Reward
                        {
                            Id = new Guid(),
                            Description = "Æt nått gott",
                            Points = -100
                        },
                        new Reward
                        {
                            Id = new Guid(),
                            Description = "Fylla",
                            Points = -10
                        },
                        new Reward
                        {
                            Id = new Guid(),
                            Description = "Drønare",
                            Points = -1000
                        }
                    }
                }
            };
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
