namespace SOLID.ISP.Good
{
	public interface IUserAuthentication
	{
		void Login(string username, string password);
		void Logout();
	}
}
