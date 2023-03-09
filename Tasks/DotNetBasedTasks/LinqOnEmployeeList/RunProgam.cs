using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validations;

namespace LinqOnEmployeeList
{
    public class RunProgram
    {
        public static List<Employee> employeeList = new List<Employee>();

        public static void Start(string[] args)
        {
            Console.WriteLine("\n\nchoose action\n\t Enter 1 to add records\n\t Enter 2 To fetch records\n");
            var action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 1:
                    {
                        RunProgram.Input(args);
                        break;
                    }
                case 2:
                    {
                        RunProgram.Query<Employee>(employeeList, args);
                        break;
                    }
                    default:
                    {
                        break;
                    }
            }
        }
        public static void Input(string[] args)
        {
            Console.WriteLine("________________Enter Employee Details as mentioned order_______________");
            Console.WriteLine("-------------------------------------------------------------------------");
            FormValidations check = new FormValidations();
            string Name, Department, email = null;
            int action = 1;
            while (action == 1)
            {
                action = 0;
                #region Capturing input values 
                Console.WriteLine(employeeList.Count);
                try
                {
                    Console.Write("Enter Employee Name: ");
                    Name = Console.ReadLine();
                    check.IsValidName(Name);
                    Console.Write("Enter EmailId: ");
                    email = Console.ReadLine();
                    check.isValidEmail(email);
                    Console.Write("Enter Department: ");
                    Department = Console.ReadLine();
                    string id = "QM" + Department[0] + Name.Substring(0, 1);
                    employeeList.Add(new Employee(id, Name, Department, email));//Adding to the Employee list
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                #endregion
                Console.WriteLine("Would you like to continue to add Employees press '1' or otherwise press '0' ");
                int dm = Convert.ToInt32(Console.ReadLine());
                if (dm == 1)
                {
                    action = 1;
                }
                else if (dm == 0)
                {
                    Console.WriteLine("___________________________________________________________________________________________");
                    action = 0;
                    RunProgram.Start(args);
                    //Start(args);
                }
            }
        }
        public static void Query<T>(List<Employee>  employeeList, string[] args)
        {
            if(employeeList.Count == 0)
            {
                Console.WriteLine("There are no records available to fetch");
                RunProgram.Start(args);
            }
        Code:
            try
            {
                string inputName = null;
                Console.Write("Enter the Name: ");
                inputName = Console.ReadLine();
                var result = from employee in employeeList where employee.Name == inputName select employee;
                if (result.Count() > 0)
                {
                    foreach (Employee employee in result)
                    {

                        Console.Write($"EmployeeId: {employee.Id}\nName : {employee.Name}\nDepartment: {employee.Department}\nEmail: {employee.Email}\n ");
                    }
                    RunProgram.Start(args);
                }
                else
                {
                    Console.WriteLine("No records found");
                    RunProgram.Start(args);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                goto Code;
            }

        }
    }
}
 