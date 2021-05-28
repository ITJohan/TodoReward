using System;
using System.Collections.Generic;
using System.Linq;
using TodoReward.Data.Model;

namespace TodoReward.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        // "Database"
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
                            Id = Guid.NewGuid(),
                            Description = "Ring Siv",
                            Points = 10,
                            RepeatInterval = 30,
                            StartTime = DateTimeOffset.Now - TimeSpan.FromDays(14)
                        },
                        new Todo
                        {
                            Id = Guid.NewGuid(),
                            Description = "Ring Solveig",
                            Points = 100,
                            RepeatInterval = 30,
                            StartTime = DateTimeOffset.Now - TimeSpan.FromDays(26)
                        },
                        new Todo
                        {
                            Id = Guid.NewGuid(),
                            Description = "Træna",
                            Points = 10,
                            RepeatInterval = 2,
                            StartTime = DateTimeOffset.Now - TimeSpan.FromDays(1)
                        },
                        new Todo
                        {
                            Id = Guid.NewGuid(),
                            Description = "Yoga",
                            Points = 10,
                            RepeatInterval = 1,
                            StartTime = DateTimeOffset.Now - TimeSpan.FromDays(1)
                        }
                    },
                    Rewards = new List<Reward>
                    {
                        new Reward
                        {
                            Id = Guid.NewGuid(),
                            Description = "1h gaming",
                            Points = -10
                        },
                        new Reward
                        {
                            Id = Guid.NewGuid(),
                            Description = "Æt nått gott",
                            Points = -100
                        },
                        new Reward
                        {
                            Id = Guid.NewGuid(),
                            Description = "Fylla",
                            Points = -10
                        },
                        new Reward
                        {
                            Id = Guid.NewGuid(),
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
