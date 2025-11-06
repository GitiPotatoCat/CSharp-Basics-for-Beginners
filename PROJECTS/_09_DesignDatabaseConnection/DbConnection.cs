

namespace _09_DesignDatabaseConnection 
{
    public abstract class DbConnection 
    {
        private readonly string _connectionString = string.Empty;
        private readonly TimeSpan _timeOut;


        public string ConnectionString => _connectionString;
        public TimeSpan TimeOut => _timeOut;


        
        public DbConnection(string connectionString, TimeSpan timeOut) 
        {
            _connectionString = connectionString;
            _timeOut = timeOut;
        }


        public abstract void Open();
        public abstract void Close();
    }
}