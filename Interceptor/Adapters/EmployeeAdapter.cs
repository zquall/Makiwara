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
        //Update the salaries for the employees in the first search
        private static void UpdateSalariesInSearch(EmployeeResponse response)
        {
            foreach(var employee in response.EmployeeList)
            {
                var code = Convert.ToDouble(employee.Code);
                var tmpEmployee = Asgard._Foreing.PLA_EMPLEADOS.Where(x => x.EMP_Numero.Equals(code) &&
                                                                           x.CIA_Codigo.Equals("01") &&
                                                                           x.EMP_Activo.Equals("S"))
                                                               .SingleOrDefault();
                if (tmpEmployee != null) employee.SalaryByHour = Convert.ToDecimal(tmpEmployee.EMP_SalarioXHora);
            }
        }

        // Add aditional results to the search
        public void SearchEmployee(EmployeeRequest request, EmployeeResponse response)
        {
            var maximunResultRows = Convert.ToInt32(Resources.MaximunSearchResults);

            // Apply the search with the pattern given
            var searchResults = Asgard._Foreing.PLA_EMPLEADOS
                                .Where(x => x.EMP_Nombre.ToUpper().Contains(request.SearchEmployeeQuery.ToUpper()) &&
                                            x.CIA_Codigo.Equals("01") &&
                                            x.EMP_Activo.Equals("S"))
                                .OrderBy(y => y.EMP_Nombre)
                                .Take(maximunResultRows)
                                .ToList();

            if (request.SearchEmployeeQuery == "") UpdateSalariesInSearch(response);

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
                    //bindedEmployee.Person.Name = employee.EMP_Nombre;
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
                    var code = Convert.ToDouble(request.Employee.Code);
                    //var code = Convert.ToDouble(request.Employee.Code.Substring(0, request.Employee.Code.Length - 2));

                    // Search the item to update data
                    var bindedEmployeeFound = Asgard._Foreing.PLA_EMPLEADOS.Where(x => x.EMP_Numero.Equals(code) &&
                                                                                 x.CIA_Codigo.Equals("01") &&
                                                                                 x.EMP_Activo.Equals("S")).FirstOrDefault();

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
                    var code = Convert.ToDouble(request.Employee.Code);
                    //var code = Convert.ToDouble(request.Employee.Code.Substring(0, request.Employee.Code.Length - 2));
                    var employeeFound = Asgard._Foreing.PLA_EMPLEADOS.Where(x => x.EMP_Numero.Equals(code) &&
                                                                                 x.CIA_Codigo.Equals("01") &&
                                                                                 x.EMP_Activo.Equals("S")).FirstOrDefault();

                    if (employeeFound != null)
                    {
                        response.Employee = new EmployeeDto
                        {
                            Code = Convert.ToString(employeeFound.EMP_Numero).Trim(),
                            UserAccountId = 0,
                            SalaryByHour = Convert.ToDecimal(employeeFound.EMP_SalarioXHora),
                            Person = new PersonDto
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
