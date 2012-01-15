using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class UserFactory
    {
        private static UserService _UserService;

        public UserFactory()
        {
            _UserService = _UserService ?? new UserService();
        }

        public UserResponse getUserByLogin(UserRequest request)
        {
            return _UserService.getUserByLogin(request);
        }
        public UserResponse getEmployeeByUserId(UserRequest request)
        {
            return _UserService.getEmployeeByUserId(request);
        }

        
    }
}
