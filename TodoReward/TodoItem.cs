using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoReward
{
    public class TodoItem
    {
        public string Description { get; set; }
        public int TimeLeft { get; set; }
        public int RepeatInterval { get; set; }
        public int Points { get; set; }
    }
}
