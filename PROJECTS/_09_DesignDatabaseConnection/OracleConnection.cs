

namespace _09_DesignDatabaseConnection 
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeOut) 
            : base(connectionString, timeOut) { }


        public override void Open() 
        {
            Console.WriteLine("Opening Oracle Connection...");
        }

        public override void Close() 
        {
            Console.WriteLine("Closing Oracle Connection...");
        }
    }
}
