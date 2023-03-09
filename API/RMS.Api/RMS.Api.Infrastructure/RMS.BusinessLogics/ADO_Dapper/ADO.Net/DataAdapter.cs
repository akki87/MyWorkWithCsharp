using System.Data;
using System.Data.SqlClient;

namespace RMS.BusinessLogics.ADO_Dapper.ADO.Net
{
    public class DataAdapter
    {
        public static void GetList(string? name = null)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RMS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            try
            {
                SqlCommand command = new SqlCommand("GetRMSStaff", connection)
                {
                    CommandType = CommandType.StoredProcedure

                };
                SqlParameter parameter = new SqlParameter("@RoleName", SqlDbType.VarChar);
                parameter.Value = name;
                command.Parameters.Add(parameter);
                connection.Open();
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(ds);
                }
                var d = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                connection.Close();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }
    }
}
