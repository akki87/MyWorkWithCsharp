using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculator
{
    public abstract class EmployeeSalaryCalculator
    {
        public string fullName { get; set; }
        public string employeeType { get; set; }
        public decimal workingDuration { get; set; }

        public abstract string SalaryCalculator(string fullname,string eployeeType,decimal workingDurtion);
    }
}
