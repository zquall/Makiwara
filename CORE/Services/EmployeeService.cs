using System;
using System.Collections.Generic;
using System.Linq;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Interceptor.Adapters;
using Nexus;
using ReplicantRepository.DataTransferObjects;
using AutoMapper;

namespace CORE.Services
{
    public class EmployeeService
    {
        private readonly EmployeeAdapter _employeeAdapter;

        public EmployeeService()
        {
            _employeeAdapter = new EmployeeAdapter();
        }

        // Search Employee
        public EmployeeResponse SearchEmployee(EmployeeRequest request)
        {
            var response = new EmployeeResponse { EmployeeList = new List<EmployeeDto>() };

            // Search employee
            var employeesFound = Olympus._Enterprise.Employees.Where(x => x.Person.Name.Contains(request.SearchEmployeeQuery) ||
                                                                          x.Code.Contains(request.SearchEmployeeQuery))
                                                              .OrderBy(y => y.Person.Name)
                                                              .Take(Convert.ToInt32(Properties.Resources.MaximunResultRows))
                                                              .Distinct()
                                                              .ToList();

            if (employeesFound.Count > 0)
            {
                response.EmployeeList = Mapper.Map<List<EmployeeDto>>(employeesFound);
            }

            // Intercepted Method
            _employeeAdapter.SearchEmployee(request, response);

            // Sorted again the list
            response.EmployeeList = response.EmployeeList.OrderBy(x => x.Person.Name).ToList();

            return response;
        }

        // Get Employee
        public EmployeeResponse GetEmployee(EmployeeRequest request)
        {
            var response = new EmployeeResponse();

            #region *** Intercepted Method ***
            // Try to add employee from AlienDB to Nexus if the employee already exist then try to refresh the information
            request.EmployeeId = SaveEmployee(new EmployeeRequest { Employee = _employeeAdapter.GetEmployee(request).Employee}).EmployeeId;

            #endregion

            // Validate if the item is from Nexus
            if (request.EmployeeId > 0)
            {
                var employeeFound = Olympus._Enterprise.Employees.Where(x => x.Id == request.EmployeeId).SingleOrDefault();
                response.Employee = Mapper.Map<EmployeeDto>(employeeFound);
            }
            return response;
        }

        // Save Item
        public EmployeeResponse SaveEmployee(EmployeeRequest request)
        {
            var response = new EmployeeResponse();

            if (request.Employee != null)
            {
                Employee employee = null;
                // Check if Edit or Add
                if (request.Employee.Id > 0)
                {
                    // Edit
                    employee = Olympus._Enterprise.Employees.Where(x => x.Id == request.Employee.Id).SingleOrDefault();

                    if (employee != null)
                    {
                        // Overrides the Salary By Hour
                        //request.Employee.SalaryByHour = employee.SalaryByHour;
                        //Mapper.Map(request.Employee, employee);
                    }
                }
                else
                {
                    // Add
                    if (request.Employee.Code != null)
                    {
                        // Check some info from AlienDB
                        employee = new Employee();
                        Mapper.Map(request.Employee, employee);
                        Olympus._Enterprise.Employees.AddObject(employee);
                    }
                }
                Olympus._Enterprise.SaveChanges(); 
                if (employee != null) response.EmployeeId = employee.Id;
            }
            return response;
        }
    }
}
