using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class CustomerFactory
    {
        private static BudgetRequestService _BudgetRequestService;
        public CustomerFactory()
        {
            _BudgetRequestService = _BudgetRequestService ?? new BudgetRequestService();
        }

        public BudgetRequestResponse getNewBudgetRequest()
        {
            return _BudgetRequestService.getNewBudgetRequest();
        }

    }
}
