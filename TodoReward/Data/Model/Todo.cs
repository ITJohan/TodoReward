using System;

namespace TodoReward.Data.Model
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int TimeLeft { get; set; }
        public int RepeatInterval { get; set; }
        public int Points { get; set; }
    }
}
