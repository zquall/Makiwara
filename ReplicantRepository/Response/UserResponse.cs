using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.DataTransferObjects;
using ReplicantRepository.DataTransferObjects.NervObjects;

namespace ReplicantRepository.Response
{
    public class UserResponse
    {
        public UserAccountDto UserAccount { get; set; }
        public EmployeeDto Employee { get; set; } 
    }


}
