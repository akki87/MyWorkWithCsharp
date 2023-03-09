using Dapper;
using RMS.Api.Core.Models;
using System.Data;
using System.Data.SqlClient;

namespace RMS.BusinessLogics.ADO_Dapper.StoredProcedures
{
	public class Sp_Insertion
	{
		public static bool InsertEmployees(Employee employee)
		{
			string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RMS;Integrated Security=True";
			SqlConnection connection = new SqlConnection(constring);
			List<dynamic> list = new List<dynamic>();
			try
			{
				string procedure = "InsertEmployee";
				var parameter = new DynamicParameters();
				parameter.Add("@FirstName", employee.FirstName);
				parameter.Add("@LastName", employee.LastName);
				parameter.Add("@Dob", employee.Dob);
				parameter.Add("@Email", employee.Email);
				connection.Open();
				var result = connection.Execute(procedure, parameter, commandType: CommandType.StoredProcedure);
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
