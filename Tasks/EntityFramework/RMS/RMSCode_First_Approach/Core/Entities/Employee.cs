using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMSCodeFirstApproach.Core.Entities
{
	public class Employee
	{
		public int Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Dob { get; set; }
		public string? Email { get; set; }
		public Employee(string? FirstName, string? LastName, string? Dob, string? Email)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Dob = Dob;
			this.Email = Email;

		}
		public Employee() { }
	}
}
