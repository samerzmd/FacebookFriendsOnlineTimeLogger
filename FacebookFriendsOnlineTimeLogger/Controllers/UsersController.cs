using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FacebookFriendsOnlineTimeLogger.Models;

namespace FacebookFriendsOnlineTimeLogger.Controllers
{
    public class UsersController : Controller
    {
        private List<User> Users = new List<User>();
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegisterResult(List<string> userNames)
        {
            var currentCheckedInUsers = new List<User>();
            foreach (var userName in userNames)
            {
                var newUser = true;
                foreach (var user in Users.Where(user => user.Name.Equals(userName)))
                {
                    newUser = false;
                    user.CheckIn();
                    currentCheckedInUsers.Add(user);
                }

                if (!newUser) continue;

                {
                    var user = new User(userName);
                    Users.Add(user);
                    currentCheckedInUsers.Add(user);
                }
            }

            foreach (var user in Users.Except(currentCheckedInUsers))
            {
                user.CheckOut();
            }

            return Json(true);
        }
    }
}