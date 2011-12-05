using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nerv;
using Cypher;
using Hades.averno;
using Nexus;

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

        private static void saveUserInSession(UserAccount userAccount)
        {
            _LogedUser = new UserSession(userAccount.Id);
            _LogedUser.EmployeeSession = getEmployeeSession(_LogedUser);
        }

        private static EmployeeSession getEmployeeSession(UserSession userAccount)
        {
            EmployeeSession employeeFromUser = new EmployeeSession();
            EnterpriseEntities enterpriseEntities = new EnterpriseEntities();
            var employeeFounded = enterpriseEntities.Employees.Where(x => x.UserAccountId == userAccount.UserId).SingleOrDefault();
            if (employeeFounded != null) {
                employeeFromUser.Id = employeeFounded.Id;
                employeeFromUser.Name = employeeFounded.Person.Name;
                employeeFromUser.LastName = employeeFounded.Person.LastName;
            }
            return employeeFromUser;
        }

        public static bool isLogedIn
        {
            get
            {
                return (_LogedUser == null) ? false : true;
            }
        }

        public static string FullName
        {
            get
            {
                return (_LogedUser.EmployeeSession.FullName == null) ? "Perfil Incompleto" : _LogedUser.EmployeeSession.FullName;
            }
        }

        public static int EmployeeId
        {
            get
            {
                return _LogedUser.EmployeeSession.Id;
            }
        }
        public static string EmployeeName
        {
            get
            {
                return _LogedUser.EmployeeSession.Name;
            }
        }
        public static string EmployeeLastName
        {
            get
            {
                return _LogedUser.EmployeeSession.LastName;
            }
        }
    }
}
