using System;
using TodoReward.Data.Model;

namespace TodoReward.Data
{
    public class UserStateContainer
    {
        private User _user;

        public User User
        {
            get => _user;
            set
            {
                _user = value;
                NotifyStateChanged();
            }
        }

        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
