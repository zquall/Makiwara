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
        private static UserService _userService;

        public UserFactory()
        {
            _userService = _userService ?? new UserService();
        }

        public UserResponse GetUserByLogin(UserRequest request)
        {
            return _userService.getUserByLogin(request);
        }
        public UserResponse GetEmployeeByUserId(UserRequest request)
        {
            return _userService.getEmployeeByUserId(request);
        }
    }
}
