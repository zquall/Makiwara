using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReplicantRepository.DataTransferObjects
{
    public class UserSessionData
    {
        private int _UserId;
        public UserSessionData (int userId)
	    {
            _UserId = userId;
	    }
        public int UserId { get { return _UserId; } }
        public EmployeeSession EmployeeSession { get; set; }
    }
    public class EmployeeSession
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return Name + " "+ LastName; } }
        public string Email { get; set; }
    }
}
