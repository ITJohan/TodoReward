using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoReward.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Points { get; set; }
        public IList<Todo> Todos { get; set; }
        public IList<Reward> Rewards { get; set; }
    }
}
