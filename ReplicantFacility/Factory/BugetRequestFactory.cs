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

        public BudgetRequestResponse getNewBudgetRequest( BudgetRequestRequest request)
        {
            return _BudgetRequestService.getNewBudgetRequest(request);
        }

        public BudgetRequestResponse searchBudgetRequest( BudgetRequestRequest request)
        {
            return _BudgetRequestService.searchBudgetRequest(request);
        }

        public BudgetRequestResponse getBudgetRequest(BudgetRequestRequest request)
        {
            return _BudgetRequestService.getBudgetRequest(request);
        }

        public BudgetRequestResponse saveBudgetRequest(BudgetRequestRequest request)
        {
            return _BudgetRequestService.saveBudgetRequest(request);
        }

    }
}
