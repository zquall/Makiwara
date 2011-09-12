using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nerv;
using Cypher;
using Hades.averno;

namespace Hades.session
{   
    public static class SessionManager
    {
        // Contains the user that is in session
        private static UserSession _LogedUser = null;

        // Try to login a user with the providen data
        public static bool Login(string username, string password)
        {
            bool result = false;
            NERVEntities nervEntities = new NERVEntities();
            var accountFounded = nervEntities.UserAccounts.Where(x => x.Account.ToUpper() == username.ToUpper()).SingleOrDefault();
            if (accountFounded != null)
            {
                var cypher = new Cryptos(Cryptos.algorithmType.DES);
                if (cypher.Encrypt(password).Equals(accountFounded.Password))
                {
                    saveUserInSession(accountFounded);
                    result = true;
                }
            }
            return result;
        }

        public static bool isLogedIn { 
            get {
                return (_LogedUser == null) ? false : true;
            } 
        }

        private static void saveUserInSession(UserAccount userAccount)
        {
            _LogedUser = new UserSession(userAccount.Id);
        }

    }
}
