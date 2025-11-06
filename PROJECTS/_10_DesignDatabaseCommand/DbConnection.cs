namespace _10_DesignDatabaseCommand 
{
    public abstract class DbConnection 
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeOut;

        public string ConnectionString => _connectionString;
        public TimeSpan TimeOut => _timeOut;

        protected DbConnection(string connectionString, TimeSpan timeOut) {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString), "Connection string cannot be null or empty");

            _connectionString = connectionString;
            _timeOut = timeOut;
        }

        public abstract void Open();
        public abstract void Close();
    }
}