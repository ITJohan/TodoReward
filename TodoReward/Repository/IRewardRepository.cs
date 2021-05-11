using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoReward.Model;

namespace TodoReward.Repository
{
    public interface IRewardRepository
    {
        void AddReward(Reward reward);
        List<Reward> GetRewards();
        Reward GetReward(int id);
        void UpdateReward(Reward reward);
        void DeleteReward(int id);
    }
}
