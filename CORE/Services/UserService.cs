using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Cypher;
using AutoMapper;
using ReplicantRepository.DataTransferObjects;
using Nerv;
using ReplicantRepository.DataTransferObjects.NervObjects;
using Nexus;
using System.Data.Objects;

namespace CORE.Services
{
    public class UserService : ServiceBase
    {
        public UserService()
        {
            
        }
                
        public UserResponse getUserByLogin(UserRequest request)
        {
            UserResponse response = new UserResponse();
            var accountFound = Olympus._Nerv.UserAccounts.Where(x => x.Account.ToUpper() == request.UserName.ToUpper()).SingleOrDefault();
            
            if (accountFound != null)
            {                
                var cypher = new Cryptos(Cryptos.algorithmType.DES);
                if (cypher.Encrypt(request.Password).Equals(accountFound.Password))
                {
                    // Map the UserAccount                    
                    Olympus._Nerv.UserAccounts.Detach(accountFound);
                    response.UserAccount = Mapper.Map<UserAccount, UserAccountDto>(accountFound);
                }
            }
            return response;
        }

        public UserResponse getEmployeeByUserId(UserRequest request)
        {
            UserResponse response = new UserResponse();
            var employeeFound = Olympus._Enterprise.Employees.Where(x => x.UserAccountId == request.UserAccount.Id).SingleOrDefault();
            if (employeeFound != null)
            {
                var person = employeeFound.Person;
                Olympus._Enterprise.Detach(person);
                Olympus._Enterprise.Detach(employeeFound);
                response.Employee = Mapper.Map<Employee, EmployeeDto>(employeeFound);
                response.Employee.Person = Mapper.Map<Person, PersonDto>(person);
            }
            return response;
        } 

    }
}
