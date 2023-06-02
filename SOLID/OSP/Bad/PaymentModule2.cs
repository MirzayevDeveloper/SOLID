using SOLID.OSP.Common;

namespace SOLID.OSP.Bad
{
	internal class PaymentModule2
	{
		public void ProcessPayment(Order order, string gatewayName)
		{
			if (gatewayName == "GatewayA")
			{
				// Existing code to process payment with GatewayA
			}
			else if (gatewayName == "GatewayB")
			{
				// Existing code to process payment with GatewayB
			}
			else if (gatewayName == "GatewayC")
			{
				// Existing code to process payment with GatewayC
			}
		}
	}

}
