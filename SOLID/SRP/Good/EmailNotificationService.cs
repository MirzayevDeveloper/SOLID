using SOLID.SRP.Common;

namespace SOLID.SRP.Good
{
	internal class EmailNotificationService
	{
		private EmailService emailService;

		public void sendWelcomeNotification(String email)
		{
			emailService.sendNotification(email, "Welcome to our platform!");
		}
	}
}
