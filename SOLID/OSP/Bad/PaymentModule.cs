using SOLID.OSP.Common;

namespace SOLID.OSP.Bad
{
	internal class PaymentModule
	{
		private Gateway gateway;

		public void processPayment(Order order)
		{
			// Existing code to process payment with a specific payment gateway
			gateway.ProcessPayment(order);
		}
	}


}
