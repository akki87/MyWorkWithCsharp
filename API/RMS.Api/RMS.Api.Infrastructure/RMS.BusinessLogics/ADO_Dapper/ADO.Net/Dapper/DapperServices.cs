using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace RMS.BusinessLogics.ADO_Dapper.ADO.Net.Dapper
{
	public class DapperServices
	{
		public static void GetList(string? name = null)
		{
			string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RMS;Integrated Security=True";
			SqlConnection connection = new SqlConnection(constring);
			List<dynamic> list = new List<dynamic>();
			try
			{
				string procedure = "GetRMSStaff";
				var parameter = new DynamicParameters();
				parameter.Add("@RoleName", name);
				var result = connection.QueryMultiple(procedure, parameter, commandType: CommandType.StoredProcedure);
				while (result.IsConsumed == false) { list.Add(result.Read().ToList()); }
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
