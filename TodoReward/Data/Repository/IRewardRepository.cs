using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoReward.Model;

namespace TodoReward.Repository
{
    public interface IRewardRepository
    {
        void AddReward(Reward reward, Guid userId);
        List<Reward> GetRewards(Guid userId);
        Reward GetReward(Guid rewardId, Guid userId);
        void UpdateReward(Reward reward, Guid userId);
        void DeleteReward(Guid rewardId, Guid userId);
    }
}
