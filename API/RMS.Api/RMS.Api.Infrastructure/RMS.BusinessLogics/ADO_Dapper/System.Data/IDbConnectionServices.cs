using Dapper;
using RMS.Api.Core.Models;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace RMS.BusinessLogics.ADO_Dapper.System.Data
{
	public class IDbConnectionServices
	{
		public static IEnumerable<Customer> GetList(string? name = null)
		{
			DataTable resultTable = new DataTable();
			List<Customer> customers = new List<Customer>();
			IDbConnection connection = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB; Database=RMS; Trusted_Connection=True; MultipleActiveResultSets=true;");
			try
			{
				IDbCommand cmd = connection.CreateCommand();
				cmd.CommandText = "GetList";
				cmd.CommandType = CommandType.StoredProcedure;
				connection.Open();
				IDataReader res = cmd.ExecuteReader();
				while (res.Read())
				{
					Customer obj = Activator.CreateInstance<Customer>();
					foreach (PropertyInfo prop in obj.GetType().GetProperties())
					{
						if (!Equals(res[prop.Name], DBNull.Value))
						{
							prop.SetValue(obj, res[prop.Name], null);
						}
					}
					customers.Add(obj);
				}
				resultTable.Load(res);
				connection.Close();

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				connection.Close();
			}
			finally
			{
				connection.Close();
			}

			return customers.AsEnumerable();
		}
		public static IEnumerable<Customer> GetListDapper(string? name = null)
		{
			DataTable resultTable = new DataTable();
			List<Customer> customers = new List<Customer>();
			IDbConnection connection = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB; Database=RMS; Trusted_Connection=True; MultipleActiveResultSets=true;");
			try
			{
				IDbCommand cmd = connection.CreateCommand();
				cmd.CommandText = "GetList";
				cmd.CommandType = CommandType.StoredProcedure;
				connection.Open();
				customers = connection.Query<Customer>("GetList").ToList();
				connection.Close();

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				connection.Close();
			}
			finally
			{
				connection.Close();
			}

			return customers.AsEnumerable();
		}

	}
}
