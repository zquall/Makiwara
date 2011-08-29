using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nerv;

namespace Merv.session
{   
    public static class SessionManager
    {
        // Contains the user that is in session
        private static string _LogedUser = null;

        // Try to login a user with the providen data
        public static bool Login(string username, string password)
        {
            bool result = false;
            NERVEntities nervEntities = new NERVEntities();
            var accountFounded = nervEntities.UserAccounts.Where(x => x.Account == username).SingleOrDefault();
            if (accountFounded != null)
            {

            }
            _LogedUser = "";
            _LogedUser.ToString();

            return result;
        }

        public static bool isLogedIn { 
            get {
                bool result = false;
                if (_LogedUser == null) 
                {
                    result = true;
                }
                return result;
            } 
        }

    }
}
