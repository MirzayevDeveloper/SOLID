namespace SOLID.DIP.Good
{
	public class DataProcessor
	{
		private IDatabaseConnection _connection;

		public DataProcessor(IDatabaseConnection connection)
		{
			_connection = connection;
		}

		public void ProcessData()
		{
			_connection.ExecuteQuery("SELECT * FROM data");
		}
	}
}
