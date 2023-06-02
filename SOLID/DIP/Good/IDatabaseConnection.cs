namespace SOLID.DIP.Good
{
	public interface IDatabaseConnection
	{
		void ExecuteQuery(string query);
	}
}
