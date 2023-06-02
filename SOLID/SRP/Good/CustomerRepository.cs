using SOLID.SRP.Common;

namespace SOLID.SRP.Good
{
	internal class CustomerRepository
	{
		private Database database;

		public void saveCustomer(Customer customer)
		{
			database.saveCustomer(customer);
		}
	}
}
