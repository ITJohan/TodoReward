﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoReward.Model
{
    public class Reward
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public int Points { get; set; }
    }
}