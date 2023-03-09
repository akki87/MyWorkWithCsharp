using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BusinessLogics.ADO.Net
{
	public class ADOServices
	{
		public static void Services(string[] args)
		{
			DataAdapter.GetList();
			DataReader.GetList();
		}
	}
}
