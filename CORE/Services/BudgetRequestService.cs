using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;
using CORE.DataMapper;

namespace CORE.Services
{
    public class BudgetRequestService
    {
        public BudgetRequestService()
        {
            
        }

        public BudgetRequestResponse getNewBudgetRequest(BudgetRequestRequest request)
        {
            var response = new BudgetRequestResponse();
            response.BudgetRequest = new BudgetRequestData();
            var employeeFound = Olympus._Enterprise.Employees.Where(x => x.UserAccountId == request.EmployeeId).SingleOrDefault();

            response.BudgetRequest.Employee.Id = employeeFound.Id;
            response.BudgetRequest.Employee.Person.Id = employeeFound.Person.Id;
            response.BudgetRequest.Employee.Person.Name = employeeFound.Person.Name;
            response.BudgetRequest.Employee.Person.LastName = employeeFound.Person.LastName;
            response.BudgetRequest.DateModified = DateTime.Today;
            response.BudgetRequest.Customer.Name = "";
            response.BudgetRequest.Customer.Address = "";

            return response;
        }

        // Get one specific BudgetRequest
        public BudgetRequestResponse getBudgetRequest(BudgetRequestRequest request)
        {
            var response = new BudgetRequestResponse();
            if (request.BudgetResquestId != 0) {
                var budgetResquestFound = Olympus._Enterprise.BudgetRequests.Where(x => x.Id == request.BudgetResquestId).SingleOrDefault();
                if ( budgetResquestFound != null )
                {    
                    response.BudgetRequest = MapperOld.Map(budgetResquestFound);
                }                
            }         
            return response;
        }

        // Search BudgetRequest
        // The search must return just the needed data to the user and the Id
        // not the whole information of the object, at the end the user will
        // request the hole data of just one object
        public BudgetRequestResponse searchBudgetRequest(BudgetRequestRequest request)
        {
            var response = new BudgetRequestResponse();
            
            // Inicitialize the list
            response.BudgetRequestList = new List<BudgetRequestData>();

            // Search in DB
            var resultFound = Olympus._Enterprise.BudgetRequests.Where(x => (x.ProjectName.Contains(request.ResquestQuery) || x.Customer.Name.Contains(request.ResquestQuery))).OrderBy(y => y.Customer.Name).Take(Convert.ToInt32(Properties.Resources.MaximunResultRows));

            if (resultFound != null)
            {
                // Fill the response with the result found
                foreach (var budgetRequest in resultFound)
                {
                    BudgetRequestData tmpBudgetRequestData = new BudgetRequestData();
                    tmpBudgetRequestData.Id = budgetRequest.Id;
                    tmpBudgetRequestData.ProjectName = budgetRequest.ProjectName;
                    tmpBudgetRequestData.Customer = new CustomerData();
                    tmpBudgetRequestData.Customer.Name = budgetRequest.Customer.Name;
                    tmpBudgetRequestData.DateModified = budgetRequest.DateModified;
                    tmpBudgetRequestData.Employee.Person.Name = budgetRequest.Employee.Person.Name;
                    tmpBudgetRequestData.Employee.Person.LastName = budgetRequest.Employee.Person.LastName;

                    response.BudgetRequestList.Add(tmpBudgetRequestData);
                }
            }
            return response;
        }
    }
}