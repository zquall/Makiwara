using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class BudgetRequestFactory
    {
        private static BudgetRequestService _budgetRequestService;

        public BudgetRequestFactory()
        {
            _budgetRequestService = _budgetRequestService ?? new BudgetRequestService();
        }

        public BudgetRequestResponse GetNewBudgetRequest( BudgetRequestRequest request)
        {
            return _budgetRequestService.GetNewBudgetRequest(request);
        }

        public BudgetRequestResponse SearchBudgetRequest( BudgetRequestRequest request)
        {
            return _budgetRequestService.SearchBudgetRequest(request);
        }

        public BudgetRequestResponse GetBudgetRequest(BudgetRequestRequest request)
        {
            return _budgetRequestService.GetBudgetRequest(request);
        }

        public BudgetRequestResponse SaveBudgetRequest(BudgetRequestRequest request)
        {
            return _budgetRequestService.SaveBudgetRequest(request);
        }

    }
}
