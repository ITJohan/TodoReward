using System;
using System.Collections.Generic;
using System.Linq;
using TodoReward.Data.Model;

namespace TodoReward.Data.Repository
{
    public class RewardRepository : IRewardRepository
    {
        private readonly IUserRepository _userRepository;

        public RewardRepository(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddReward(Reward reward, Guid userId)
        {
            User user = _userRepository.GetUser(userId);

            if (user != null)
            {
                user.Rewards.Add(reward);

                // TODO: Save changes
            }
        }

        public void DeleteReward(Guid rewardId, Guid userId)
        {
            User user = _userRepository.GetUser(userId);

            if (user == null)
            {
                return;
            }

            Reward reward = user.Rewards.FirstOrDefault(r => r.Id == rewardId);

            if (reward != null)
            {
                user.Rewards.Remove(reward);

                // TODO: Save changes
            }
        }

        public Reward GetReward(Guid rewardId, Guid userId)
        {
            User user = _userRepository.GetUser(userId);

            if (user == null)
            {
                return null;
            }

            return user.Rewards.FirstOrDefault(r => r.Id == rewardId);
        }

        public List<Reward> GetRewards(Guid userId)
        {
            User user = _userRepository.GetUser(userId);

            if (user == null)
            {
                return null;
            }

            return user.Rewards.ToList();
        }

        public void UpdateReward(Reward reward, Guid userId)
        {
            User user = _userRepository.GetUser(userId);

            if (user == null)
            {
                return;
            }

            Reward rewardToUpdate = user.Rewards.FirstOrDefault(r => r.Id == reward.Id);

            if (rewardToUpdate != null)
            {
                rewardToUpdate.Description = reward.Description;
                rewardToUpdate.Count = reward.Count;
                rewardToUpdate.Points = reward.Points;

                // TODO: Save changes;
            }
        }
    }
}