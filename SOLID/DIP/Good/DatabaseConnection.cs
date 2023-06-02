namespace SOLID.DIP.Good
{
	public class DatabaseConnection : IDatabaseConnection
	{
		private string _connectionString;

		public DatabaseConnection(string connectionString)
		{
			_connectionString = connectionString;
		}

		public void ExecuteQuery(string query)
		{
		}
	}
}
