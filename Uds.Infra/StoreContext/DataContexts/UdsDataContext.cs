using System;
using System.Data;
using System.Data.SqlClient;


namespace Uds.Infra.StoreContext.DataContexts
{
    public class UdsDataContext : IDisposable
    {
        //public static string ConnectionString = @"Server=.\sqlexpress;Database=Banco-wb;User ID=baltastore;Password=sqlexpress;";
        public static string ConnectionString = @"Server=localhost;Database=Banco-wb;Trusted_Connection=True;";
        //public static string ConnectionString = @"Server=.\\DESKTOP-KT8U7JJ;Database=Banco-wb;Integrated Security=True;";

        public SqlConnection Connection { get; set; }

        public UdsDataContext()
        {
            Connection = new SqlConnection(ConnectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}