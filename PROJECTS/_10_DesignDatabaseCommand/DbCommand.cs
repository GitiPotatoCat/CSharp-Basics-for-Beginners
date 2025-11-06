

namespace _10_DesignDatabaseCommand 
{
    public class DbCommand 
    {
        private readonly DbConnection _connection;
        private readonly string _instruction;

        public DbCommand(DbConnection? connection, string instruction) 
        {
            if (connection == null)
                throw new ArgumentNullException(nameof(connection), "Connection cannot be null");
            if (string.IsNullOrWhiteSpace(instruction)) 
                throw new ArgumentNullException(nameof(instruction), "Instruction cannot be null or empty");

            _connection = connection;
            _instruction = instruction;
        }

        public void Execute() 
        {
            if (_connection == null)
                throw new InvalidOperationException("Connection is not initialized");

            try {
                _connection.Open();
                Console.WriteLine($"Executing instruction: {_instruction}");
                _connection.Close();
            } catch (Exception) {
                _connection.Close();
                throw;
            }
        }
    }
}