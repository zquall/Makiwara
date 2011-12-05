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

        public BudgetRequestResponse searchBudgetRequest( BudgetRequestRequest request)
        {
            return _BudgetRequestService.searchBudgetRequest(request);
        }

        public BudgetRequestResponse getBudgetRequest(BudgetRequestRequest request)
        {
            return _BudgetRequestService.getBudgetRequest(request);
        }

    }
}
