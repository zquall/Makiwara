using System;
using System.Collections.Generic;
using System.Linq;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;
using AutoMapper;
using Nexus;

namespace CORE.Services
{
    public class BudgetRequestService
    {
        public BudgetRequestResponse SaveBudgetRequest(BudgetRequestRequest request)
        {
            var response = new BudgetRequestResponse();
            if (request.BudgetRequest != null)
            {
                // Check if is a insert or an update
                if (request.BudgetRequest.Id == 0)
                {
                    // Map the Customer with Contacts
                    BudgetRequest budgetRequest = Mapper.Map<BudgetRequestDto, BudgetRequest>(request.BudgetRequest);
                    Olympus._Enterprise.BudgetRequests.AddObject(budgetRequest);
                    Olympus._Enterprise.SaveChanges();
                    response.BudgetRequestId = budgetRequest.Id;
                }
                else
                {
                    var budgetRequestEntity = Olympus._Enterprise.BudgetRequests.Where( x => x.Id == request.BudgetRequest.Id).SingleOrDefault();
                    var budgetRequest = Mapper.Map<BudgetRequestDto, BudgetRequest>(request.BudgetRequest, budgetRequestEntity);
                    Olympus._Enterprise.SaveChanges();
                    response.BudgetRequestId = budgetRequest.Id;
                }
            }
            return response;
        }

        public BudgetRequestResponse GetNewBudgetRequest(BudgetRequestRequest request)
        {
            var response = new BudgetRequestResponse {BudgetRequest = new BudgetRequestDto()};
            var employeeFound = Olympus._Enterprise.Employees.Where(x => x.UserAccountId == request.EmployeeId).SingleOrDefault();
            
            // Person
            if (employeeFound != null)
            {
                var personEntity = employeeFound.Person;
                Olympus._Enterprise.Detach(personEntity);
                var person = Mapper.Map<PersonDto>(personEntity);

                // Employee
                Olympus._Enterprise.Detach(employeeFound);
                response.BudgetRequest.Employee = Mapper.Map<EmployeeDto>(employeeFound);
                response.BudgetRequest.Employee.Person = person;
            }

            // Dates
            response.BudgetRequest.DateModified = DateTime.Today;
            response.BudgetRequest.BudgetRequestCondition = new BudgetRequestConditionDto {StartDate = DateTime.Today};
            return response;
        }

        // Get one specific BudgetRequest
        public BudgetRequestResponse GetBudgetRequest(BudgetRequestRequest request)
        {
            var response = new BudgetRequestResponse();
            if (request.BudgetResquestId != 0) {
                var budgetResquestFound = Olympus._Enterprise.BudgetRequests.Where(x => x.Id == request.BudgetResquestId).SingleOrDefault();
                if ( budgetResquestFound != null )
                {                    
                    //response.BudgetRequest = MapperPaths.Map(budgetResquestFound);
                    response.BudgetRequest = Mapper.Map<BudgetRequestDto>(budgetResquestFound);
                }                
            }         
            return response;
        }

        // Search BudgetRequest
        // The search must return just the needed data to the user and the Id
        // not the whole information of the object, at the end the user will
        // request the hole data of just one object
        public BudgetRequestResponse SearchBudgetRequest(BudgetRequestRequest request)
        {
            var response = new BudgetRequestResponse {BudgetRequestList = new List<BudgetRequestDto>()};

            // Inicitialize the list

            // Search in DB
            var resultFound = Olympus._Enterprise.BudgetRequests.Where(x => (x.ProjectName.Contains(request.ResquestQuery) || x.Customer.Name.Contains(request.ResquestQuery))).OrderBy(y => y.Customer.Name).Take(Convert.ToInt32(Properties.Resources.MaximunResultRows)).ToList();

            if (resultFound != null)
            {
                // Fill the response with the result found
                foreach (var tmpBudgetRequest in resultFound)
                {
                    var budgetRequest = Mapper.Map<BudgetRequestDto>(tmpBudgetRequest);
                    response.BudgetRequestList.Add(budgetRequest);
                }
            }
            return response;
        }
    }
}