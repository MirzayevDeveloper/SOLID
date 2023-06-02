using SOLID.OSP.Common;

namespace SOLID.OSP.Good
{
	internal class PaymentModule
	{
		private IPaymentGateway paymentGateway;

		public PaymentModule(IPaymentGateway paymentGateway)
		{
			this.paymentGateway = paymentGateway;
		}

		public void ProcessPayment(Order order)
		{
			paymentGateway.ProcessPayment(order);
		}
	}

}
