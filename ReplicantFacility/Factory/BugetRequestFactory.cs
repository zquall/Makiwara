using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class BudgetRequestFactory
    {
        private static BudgetRequestService _BudgetRequestService;
        public BudgetRequestFactory()
        {
            _BudgetRequestService = _BudgetRequestService ?? new BudgetRequestService();
        }

        public BudgetRequestResponse getNewBudgetRequest()
        {
            return _BudgetRequestService.getNewBudgetRequest();
        }

    }
}
