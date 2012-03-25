using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class EmployeeFactory
    {
        private static EmployeeService _employeeService;

        public EmployeeFactory()
        {
            _employeeService = _employeeService ?? new EmployeeService();
        }

        // Search
        public EmployeeResponse SearchEmployee(EmployeeRequest request)
        {
            return _employeeService.SearchEmployee(request);
        }

        // Get
        public EmployeeResponse GetEmployee(EmployeeRequest request)
        {
            return _employeeService.GetEmployee(request);
        }

        // Save
        public EmployeeResponse SaveEmployee(EmployeeRequest request)
        {
            return _employeeService.SaveEmployee(request);
        }
    }
}
