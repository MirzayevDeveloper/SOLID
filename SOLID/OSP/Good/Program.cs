using SOLID.OSP.Common;

namespace SOLID.OSP.Good
{
	public class Program
	{
		public void Start()
		{
			IPaymentGateway gateway = new GatewayA(); // Or GatewayB, etc.
			PaymentModule paymentModule = new PaymentModule(gateway);
			paymentModule.ProcessPayment(new Order());
		}
	}
}
