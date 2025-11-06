

namespace _09_DesignDatabaseConnection 
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan timeOut)
            : base(connectionString, timeOut) { }

        public override void Open() 
        {
            Console.WriteLine("Opening SQL Server connection...");
        }

        public override void Close() 
        {
            Console.WriteLine("Closing SQL Server connection...");
        }
    }
}