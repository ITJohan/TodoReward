using System;

namespace TodoReward.Shared.Model
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public int RepeatInterval { get; set; }
        public int Points { get; set; }
        public int TimeLeft { get; set; }
    }
}
