using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.DataTransferObjects;
using ReplicantRepository.DataTransferObjects.NervObjects;

namespace ReplicantRepository.Request
{
    public class UserRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserAccountDto UserAccount { get; set; }
    }

}
