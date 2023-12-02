using System.Data;
using System.Data.SqlClient;

namespace EmployeeManager
{
    internal class ProcessDatabase
    {
        private string connectString = @"Data Source=HIEU-MAI\SQLEXPRESS;Initial Catalog=manager_employee;Integrated Security=True";

        public DataTable DocBang(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            return dt;
        }

        public void CapNhat(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}