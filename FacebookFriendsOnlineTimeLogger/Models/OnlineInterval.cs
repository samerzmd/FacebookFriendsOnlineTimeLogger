using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookFriendsOnlineTimeLogger.Models
{
    public class OnlineInterval
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsUseableInterval { get; set; }

    }
}
