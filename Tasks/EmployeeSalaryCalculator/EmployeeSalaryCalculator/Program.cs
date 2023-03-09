// See https://aka.ms/new-console-template for more information
using System;
using EmployeeSalaryCalculator;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var Obj = new SCalculator();
            Console.WriteLine("Plase Enter Employee Details\n\n");
            Console.Write("Enter Full name: ");
            var fname = Console.ReadLine();
            Console.Write("Enter Employee type(Permanent or Temporary): ");
            var EmpType = Console.ReadLine();
            Console.Write("Enter working time: ");
            var duration = Convert.ToDecimal(Console.ReadLine());   
            Console.WriteLine(Obj.SalaryCalculator(fname, EmpType,duration));

        }
    }
}
