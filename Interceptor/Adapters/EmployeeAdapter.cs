using System;
using System.Linq;
using Interceptor.Properties;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace Interceptor.Adapters
{
    public class EmployeeAdapter
    {
        // Add aditional results to the search
        public void SearchEmployee(EmployeeRequest request, EmployeeResponse response)
        {
            var maximunResultRows = Convert.ToInt32(Resources.MaximunSearchResults);

            // Apply the search with the pattern given
            var searchResults = Asgard._Foreing.PLA_EMPLEADOS
                .Where(x => x.EMP_Nombre.ToUpper().Contains(request.SearchEmployeeQuery.ToUpper()) ||
                            x.ID.Equals(Convert.ToInt32(request.SearchEmployeeQuery)))
                            .OrderBy(y => y.EMP_Nombre)
                            .Take(maximunResultRows).ToList();

            // Fill the response with the result found
            foreach (var employee in searchResults) //Por cada empleada encontrado en DIALCOM
            {
                // Check if the employee is already binded
                var bindedEmployee = response.EmployeeList.Where(x => x.Code == Convert.ToString(employee.EMP_Numero)).FirstOrDefault();
                if (bindedEmployee == null)
                {
                    var employeeDto = new EmployeeDto
                                          {
                                              UserAccountId = 0,
                                              Code = Convert.ToString(employee.EMP_Numero),
                                              SalaryByHour = Convert.ToDecimal(employee.EMP_SalarioXHora),
                                              Person = new PersonDto
                                                           {
                                                               Name = employee.EMP_Nombre,
                                                               LastName = ""
                                                           }
                                          };
                    response.EmployeeList.Add(employeeDto);
                }
                else
                {
                    bindedEmployee.SalaryByHour = Convert.ToDecimal(employee.EMP_SalarioXHora);
                    bindedEmployee.Person.Name = employee.EMP_Nombre;
                }
            }
        }

        // Get Employee from Alien DB
        public EmployeeResponse GetEmployee(EmployeeRequest request)
        {
            var response = new EmployeeResponse();

            if (request.Employee != null)
            {
                // Check for update an item
                if (request.EmployeeId > 0)
                {
                    #region Update Data
                    // Search the item to update data
                    var bindedEmployeeFound = Asgard._Foreing.PLA_EMPLEADOS
                        .Where(x => Convert.ToString(x.EMP_Numero).ToUpper() == request.Employee.Code.ToUpper())
                        .FirstOrDefault();

                    if (bindedEmployeeFound != null)
                    {
                        // Create an object to be mapped later
                        response.Employee = new EmployeeDto
                        {
                            Id = request.EmployeeId,
                            PersonId = request.Employee.PersonId,
                            Code = Convert.ToString(bindedEmployeeFound.EMP_Numero).Trim(),
                            UserAccountId = 0,
                            SalaryByHour = Convert.ToDecimal(bindedEmployeeFound.EMP_SalarioXHora)
                            //Falta actualizar los datos de la persona (Nombre y Apellidos)
                        };
                    }
                    #endregion
                }
                else
                {
                    #region Get Item
                    // Search the item
                    var employeeFound = Asgard._Foreing.PLA_EMPLEADOS.Where(x => Convert.ToString(x.EMP_Numero).ToUpper() == request.Employee.Code.ToUpper()).
                            FirstOrDefault();

                    if (employeeFound != null)
                    {
                        response.Employee = new EmployeeDto
                        {
                            Code = Convert.ToString(employeeFound.EMP_Numero).Trim(),
                            UserAccountId = 0,
                            SalaryByHour = Convert.ToDecimal(employeeFound.EMP_SalarioXHora),
                            Person = new PersonDto()
                                         {
                                             Name = employeeFound.EMP_Nombre,
                                             LastName = ""
                                         }
                        };
                    }
                    #endregion
                }
            }
            return response;
        }

    }
}
