using System;

namespace TodoReward.Shared.Model
{
    public class Reward
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public int Points { get; set; }
    }
}
