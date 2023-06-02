using SOLID.SRP.Common;

namespace SOLID.SRP.Good
{
	internal class CustomerManagement
	{
		private CustomerRepository customerRepository;
		private EmailNotificationService emailNotificationService;

		public void addCustomer(Customer customer)
		{
			customerRepository.saveCustomer(customer);
			emailNotificationService.sendWelcomeNotification(customer.getEmail().ToString());
		}
	}
}
