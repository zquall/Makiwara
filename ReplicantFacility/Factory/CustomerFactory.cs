using CORE.Services;
using ReplicantRepository.Response;
using ReplicantRepository.Request;

namespace ReplicantFacility.Factory
{
    public class CustomerFactory
    {
        private static CustomerService _customerService;

        public CustomerFactory()
        {
            _customerService = _customerService ?? new CustomerService();
        }

        public CustomerResponse SearchCustomer(CustomerRequest request)
        {
            return _customerService.SearchCustomer(request);
        }

        public CustomerResponse GetCustomer(CustomerRequest request)
        {
            return _customerService.GetCustomer(request);
        }

        public CustomerResponse GetCustomerContact(CustomerRequest request)
        {
            return _customerService.GetCustomerContact(request);
        }

        public CustomerResponse SaveCustomerContact(CustomerRequest request)
        {
            return _customerService.SaveCustomerContact(request);
        }

        public CustomerResponse SaveCustomer(CustomerRequest request)
        {
            return _customerService.SaveCustomer(request);
        }
        
    }
}
