using System.Collections.Generic;
using System.Linq;
using TodoReward.Model;

namespace TodoReward.Repository
{
    public class RewardRepository : IRewardRepository
    {
        private IList<Reward> _rewards;

        public RewardRepository()
        {
            _rewards = new List<Reward>
            {
                new Reward
                {
                    Id = 1,
                    Description = "1h gaming",
                    Points = -10
                },
                new Reward
                {
                    Id = 2,
                    Description = "Æt nått gott",
                    Points = -100
                },
                new Reward
                {
                    Id = 3,
                    Description = "Fylla",
                    Points = -10
                },
                new Reward
                {
                    Id = 4,
                    Description = "Drønare",
                    Points = -1000
                }
            };
        }

        public void AddReward(Reward reward)
        {
            _rewards.Add(reward);
        }

        public void DeleteReward(int id)
        {
            Reward reward = _rewards.FirstOrDefault(r => r.Id == id);

            if (reward != null)
            {
                _rewards.Remove(reward);
            }
        }

        public Reward GetReward(int id)
        {
            return _rewards.FirstOrDefault(r => r.Id == id);
        }

        public List<Reward> GetRewards()
        {
            return _rewards.ToList();
        }

        public void UpdateReward(Reward reward)
        {
            DeleteReward(reward.Id);
            AddReward(reward);
        }
    }
}