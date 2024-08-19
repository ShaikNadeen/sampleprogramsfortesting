using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class CustomerRepository
{
    private readonly string connectionString;

    public CustomerRepository()
    {
        connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
    }

    public DataTable GetCustomers()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT CustomerID, Name, Email FROM Customers";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            connection.Open();
            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}