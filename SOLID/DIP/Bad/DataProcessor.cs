namespace SOLID.DIP.Bad
{
	public class DataProcessor
	{
		private DatabaseConnection _connection;

		public DataProcessor()
		{
			_connection = new DatabaseConnection("connectionString");
		}

		public void ProcessData()
		{
			// Use the database connection to perform data processing operations
			_connection.ExecuteQuery("SELECT * FROM data");
			// ...
		}
	}

}
