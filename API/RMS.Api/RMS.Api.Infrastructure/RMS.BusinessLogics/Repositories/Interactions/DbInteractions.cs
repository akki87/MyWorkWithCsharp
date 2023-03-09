using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Reflection;

namespace RMS.Api.Infrastructure.Interactions
{

	public class DbInteractions<TEntity> where TEntity : class
	{
		protected DbContext Context;
		public readonly DbSet<TEntity> Dbset = null!;
		public DbInteractions(DbContext context)
		{
			this.Context = context;
			this.Dbset = context.Set<TEntity>();
		}
		public static DataTable ToDataTable(List<TEntity> items)
		{
			DataTable dataTable = new DataTable(typeof(TEntity).Name);

			//Get all the properties
			PropertyInfo[] Props = typeof(TEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
			foreach (PropertyInfo prop in Props)
			{
				//Defining type of data column gives proper data table 
				var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
				//Setting column names as Property names
				dataTable.Columns.Add(prop.Name, type);
			}
			foreach (TEntity item in items)
			{
				var values = new object[Props.Length];
				for (int i = 0; i < Props.Length; i++)
				{
					//inserting property values to datatable rows
					values[i] = Props[i].GetValue(item, null);
				}
				dataTable.Rows.Add(values);
			}
			//put a breakpoint here and check datatable
			return dataTable;
		}


		public void PrintAllRecords(IEnumerable<TEntity>? dataset = null)
		{

			var list = dataset==null ? GetAllRecords() : dataset;
			Console.WriteLine(list.Count());
			var str = "";
			foreach (var category in list)
			{
				var props = category.GetType().GetProperties().ToList();
				for (int i = 0; i < props.Count; i++)
				{
					var val = category.GetType().GetProperty(props[i].Name).GetValue(category, null) == null ? -1 : category.GetType().GetProperty(props[i].Name).GetValue(category, null);
					str += $"{val}  ";
				}
				Console.WriteLine(str);
				Console.ReadLine();
				str = "";
			}

		}

		public bool UpdateRecord(int id, params object[] args)
		{
			var props = GetRecordById(id).GetType().GetProperties().Select(x => x.Name).ToList();
			TEntity record = GetRecordById(id);
			for (int j = 0; j < args.Length; j += 2)
			{
				foreach (PropertyInfo property in record.GetType().GetProperties())
				{
					if (property.Name==args[j].ToString())
					{
						property.SetValue(record, args[j + 1], null);
						Context.SaveChanges();
						break;
					}
				}
			}
			Dbset.Update(record);
			Context.Update(record);
			Context.SaveChanges();
			return true;
		}


		public virtual TEntity GetRecordById(object id)
		{
			return Dbset.Find(id);
		}
		public bool AddRecord(params object[] args)
		{

			var customer = Activator.CreateInstance(typeof(TEntity), args);
			Dbset.Add((TEntity)customer);
			Context.SaveChanges();
			return true;
		}

		public bool RemoveRecord(params object[] args)
		{
			PropertyInfo[] props = typeof(TEntity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
			for (int i = 0; i < args.Length; i++)
			{
				var obj = Dbset.Find(args[0]);
				Dbset.Remove((TEntity)obj);
				Context.SaveChanges();
			}
			return true;
		}
		public virtual IQueryable<TEntity>? GetAllRecords()
		{
			if (Dbset == null) Console.WriteLine("No rows");
			IQueryable<TEntity> result = from record in Dbset select record;
			//var v = Dbset.AsEnumerable();
			return result;
		}

		public virtual IEnumerable<TEntity> GetAllRecords(int? page = 1,
			int? pageSize = 10,
			string? sortColumn = null,
			string sortOrder = "Asc",
			string? includeProperties = null,
			params Expression<Func<TEntity, bool>>[] filter)
		{
			IQueryable<TEntity> tabledata = Dbset;
			foreach (var item in filter)
			{
				if (filter != null)
				{
					tabledata = tabledata.Where(item);
				}
			}
			tabledata = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
				.Aggregate(tabledata, (current, includeProperty) => current.Include(includeProperty));

			if (!string.IsNullOrEmpty(sortColumn))
			{
				if (!string.IsNullOrEmpty(sortOrder) && sortOrder.ToLower().Contains("Asc".ToLower()))
				{
					tabledata = tabledata.OrderBy(sortColumn);
				}
				else
				{
					tabledata = tabledata.OrderBy(sortColumn).Reverse();
				}
			}
			if (tabledata.Count() < pageSize) page = 1;
			if (page != null && pageSize != null)
				tabledata = tabledata
					.Skip((page.Value - 1) * pageSize.Value)
					.Take(pageSize.Value);

			return tabledata;

		}


	}
}


