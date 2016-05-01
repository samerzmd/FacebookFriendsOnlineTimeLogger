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
        public List<DateTime> DateTimes { get; set; }

    }
}
