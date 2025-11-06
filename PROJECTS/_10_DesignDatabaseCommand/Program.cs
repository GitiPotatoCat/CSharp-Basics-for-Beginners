/*
        Now that we have the concept of a DbConnection, let’s work out how to represent a 
    DbCommand. 
    Design a class called DbCommand for executing an instruction against the database. A 
    DbCommand cannot be in a valid state without having a connection. So in the constructor of 
    this class, pass a DbConnection. Don’t forget to cater for the null.
     Each DbCommand should also have the instruction to be sent to the database. In case of SQL 
    Server, this instruction is expressed in T-SQL language. Use a string to represent this instruction. 
    Again, a command cannot be in a valid state without this instruction. So make sure to receive it 
    in the constructor and cater for the null reference or an empty string. 
    Each command should be executable. So we need to create a method called Execute(). In this 
    method, we need a simple implementation as follows: 

    Open the connection
        Run the instruction 
    Close the connection
        Note that here, inside the DbCommand, we have a reference to DbConnection. Depending on 
    the type of DbConnection sent at runtime, opening and closing a connection will be different. 
    For example, if we initialize this DbCommand with a SqlConnection, we will open and close a 
    connection to a Sql Server database. This is polymorphism. Interestingly, DbCommand doesn’t 
    care about how a connection is opened or closed. It’s not the responsibility of the DbCommand. 
    All it cares about is to send an instruction to a database. 
    For running the instruction, simply output it to the Console. In the real-world, SQL Server (or any 
    other DBMS) provides an API for running an instruction against the database. We don’t need to 
    worry about it for this exercise. 
    
    In the main method, initialize a DbCommand with some string as the instruction and a 
    SqlConnection. Execute the command and see the result on the console.
     Then, swap the SqlConnection with an OracleConnection and see polymorphism in action
*/

using System;

namespace _10_DesignDatabaseCommand 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            try {
                var sqlConnection = new SqlConnection("Server=myServerAddress;Database=myDataBase;", TimeSpan.FromSeconds(30));
                var sqlCommand = new _10_DesignDatabaseCommand.DbCommand(sqlConnection, "SELECT * FROM Users");

                Console.WriteLine("Executing SQL Command:");
                sqlCommand.Execute();
                Console.WriteLine();


                var oracleConnection = new OracleConnection("Data Source=MyOracleDB;", TimeSpan.FromSeconds(30));
                var oracleCommand = new DbCommand(oracleConnection, "SELECT * FROM Users");

                Console.WriteLine("Executing Oracle Command:");
                oracleCommand.Execute();
                Console.WriteLine();


                try {
                    var invalidCommand = new _10_DesignDatabaseCommand.DbCommand(null, "SELECT * FROM Users");
                } catch (ArgumentNullException ex) {
                    Console.WriteLine($"Validation worked: {ex.Message}");
                }
            } catch (Exception ex) {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }



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
}