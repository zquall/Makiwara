using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using Hades.session;

namespace CORE.Services
{
    public class BudgetRequestService
    {
        public BudgetRequestService()
        {
            
        }

        public BudgetRequestResponse getNewBudgetRequest()
        {
            var response = new BudgetRequestResponse();
            response.EmployeeName = Hades.session.SessionManager.FullName;
            response.DateModified = DateTime.Today;
            response.Customer = new CustomerData();
            response.Customer.Name = "";
            response.Customer.Address = "";

            return response;
        }
    }
}