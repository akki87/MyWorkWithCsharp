using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using RMSCodeFirstApproach.RMS.Core.Entities;
using System.Data.Entity.Core.Objects;
using RMSCodeFirstApproach.Context;
using System.Data.Common;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Reflection.PortableExecutable;
using System.Reflection;
using Dapper;

namespace RMS.BusinessLogics.System.Data
{
	public class IDbConnectionServices
	{
		public static IEnumerable<Customer> GetList(string? name=null) 
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
						if (!object.Equals(res[prop.Name], DBNull.Value))
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
				connection.Close ();
			}
			
			return (IEnumerable<Customer>)customers.AsEnumerable();
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
