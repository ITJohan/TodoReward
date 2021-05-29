using System;
using System.Collections.Generic;

namespace TodoReward.Shared.Model
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
