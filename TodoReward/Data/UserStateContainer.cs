using System;
using TodoReward.Data.Model;

namespace TodoReward.Data
{
    public class UserStateContainer
    {
        private int _points;

        public int Points
        {
            get => _points;
            set
            {
                _points = value;
                NotifyStateChanged();
            }
        }

        public event Action OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
