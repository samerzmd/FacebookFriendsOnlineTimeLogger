using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookFriendsOnlineTimeLogger.Models
{
    public class User
    {
        public string Name { get; set; }
        public List<OnlineInterval> OnlineIntervals { get; set; }

        public User(string name)
        {
            Name = name;
            CheckIn();
        }

        public void CheckIn()
        {
            var lastInterval = OnlineIntervals.Last();
            if (lastInterval != null && lastInterval.IsUseableInterval)
            {
                lastInterval.EndTime = DateTime.Now;
            }
            else
            {
                OnlineIntervals.Add(new OnlineInterval { StartTime = DateTime.Now, EndTime = DateTime.Now, IsUseableInterval = true });
            }
        }

        public void CheckOut()
        {
            var lastInterval = OnlineIntervals.Last();
            if (lastInterval != null && lastInterval.IsUseableInterval)
            {
                lastInterval.IsUseableInterval = false;
            }
        }

    }
}
