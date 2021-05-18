using System;

namespace TodoReward.Data.Model
{
    public class Reward
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public int Points { get; set; }
    }
}
