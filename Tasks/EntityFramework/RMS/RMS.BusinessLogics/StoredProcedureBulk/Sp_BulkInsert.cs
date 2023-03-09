using RMSCodeFirstApproach.Core.Entities;
using RMSCodeFirstApproach.Interactions;
using System.Data;
using System.Data.SqlClient;

namespace RMS.BusinessLogics.StoredProcedureBulk
{
	public class Sp_BulkInsert
	{
		public static bool InsertEmployees(List<Employee> employeeList)
		{
			string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RMS;Integrated Security=True";
			SqlConnection connection = new SqlConnection(constring);
			DataTable table = DbInteractions<Employee>.ToDataTable(employeeList);
			try
			{
				SqlCommand procedure = new SqlCommand("InsertEmployees",connection);
				procedure.CommandType=CommandType.StoredProcedure;
				SqlParameter parameter = procedure.Parameters.AddWithValue("@Employee",table);
				parameter.SqlDbType = SqlDbType.Structured;
				connection.Open();
				procedure.ExecuteNonQuery();
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
			return true;
		}
	}
}
