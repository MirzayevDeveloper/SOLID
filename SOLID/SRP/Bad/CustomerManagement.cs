using SOLID.SRP.Common;

namespace SOLID.SRP.Bad
{
	class CustomerManagement
	{
		private Database database;
		private EmailService emailService;

		public void addCustomer(Customer customer)
		{
			// Store customer data
			database.saveCustomer(customer);

			// Send email notification
			emailService.sendNotification(customer.getEmail(), "Welcome to our platform!");
		}
	}
}
