using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoReward.Data.Model;

namespace TodoReward.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
