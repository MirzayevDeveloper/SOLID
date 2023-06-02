using SOLID.OSP.Common;

namespace SOLID.OSP.Good
{
	internal interface IPaymentGateway
	{
		void ProcessPayment(Order order);
	}
}
