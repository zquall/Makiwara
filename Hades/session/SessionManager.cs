using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;
using ReplicantFacility.Factory;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects.NervObjects;

namespace Hades.Session
{   
    public static class SessionManager
    {
        // Contains the user that is in session
        private static UserSessionData _LogedUser = null;

        // Try to login a user with the providen data
        public static bool Login(string username, string password)
        {
            bool result = false;
            var request = new UserRequest();
            request.UserName = username;
            request.Password = password;
            var accountFound = new UserFactory().getUserByLogin(request).UserAccount;
            if (accountFound != null)
            {
                saveUserInSession(accountFound);
                result = true;
            }
            return result;
        }        

        private static void saveUserInSession(UserAccountDto userAccount)
        {
            _LogedUser = new UserSessionData(userAccount.Id);
            _LogedUser.EmployeeSession = getEmployeeSession(_LogedUser);
        }

        private static EmployeeSession getEmployeeSession(UserSessionData userSession)
        {
            EmployeeSession employeeFromUser = new EmployeeSession();
            var userAccount = new UserAccountDto() { Id = userSession.UserId};
            var request = new UserRequest() { UserAccount = userAccount };

            var employeeFound = new UserFactory().getEmployeeByUserId(request).Employee;

            if (employeeFound != null)
            {
                employeeFromUser.Id = employeeFound.Id;
                employeeFromUser.Name = employeeFound.Person.Name;
                employeeFromUser.LastName = employeeFound.Person.LastName;
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
