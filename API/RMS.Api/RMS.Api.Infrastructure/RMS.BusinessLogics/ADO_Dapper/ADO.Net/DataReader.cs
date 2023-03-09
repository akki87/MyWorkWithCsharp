using System.Data;
using System.Data.SqlClient;

namespace RMS.BusinessLogics.ADO_Dapper.ADO.Net
{
	public class DataReader
	{
		public static void GetList(string? name = null)
		{
			string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RMS;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			try
			{
				DataSet ds = new DataSet();
				SqlCommand command = new SqlCommand("GetRMSStaff", connection)
				{
					CommandType = CommandType.StoredProcedure
				};
				SqlParameter parameter = new SqlParameter("@RoleName", SqlDbType.VarChar);
				parameter.Value = name;
				command.Parameters.Add(parameter);
				connection.Open();
				SqlDataReader res = command.ExecuteReader();
				if (res != null)
				{
					while (res.Read())
					{
						Console.WriteLine(res[1]);
					}
				}
				res.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message.ToString());
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
