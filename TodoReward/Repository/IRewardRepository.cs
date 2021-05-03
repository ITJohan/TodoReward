using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoReward.Model;

namespace TodoReward.Repository
{
    public interface IRewardRepository
    {
        bool AddReward(Reward reward);
        List<Reward> GetRewards();
        Reward GetReward(int id);
        bool UpdateReward(Reward reward);
        bool DeleteReward(int id);
    }
}
