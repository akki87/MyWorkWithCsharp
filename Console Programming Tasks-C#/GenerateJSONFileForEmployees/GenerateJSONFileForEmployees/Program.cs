// See https://aka.ms/new-console-template for more information
using GenerateJSONFileForEmployees;
using Validations;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
     {
        List<Employee> employees = new List<Employee>();
        FormValidations check = new FormValidations();
        Json file = new Json();
        Console.WriteLine("________________Enter Employee Details as mentioned order_______________");
        Console.WriteLine("-------------------------------------------------------------------------");
        string Name, Designation, email, Department, EmployeeDetails = null;
        int action = 1;
        while (action == 1)
        {
            action = 0;
            #region Capturing input values 
            Console.WriteLine(employees.Count);
            try
            {
                Console.WriteLine("Enter Employee Name");
                Name = Console.ReadLine();
                check.IsValidName(Name);
                Console.WriteLine("Enter the Designation");
                Designation = Console.ReadLine();
                check.IsValidName(Designation);
                Console.WriteLine("Enter EmailId");
                email = Console.ReadLine();
                check.isValidEmail(email);
                Console.WriteLine("Enter Department");
                Department = Console.ReadLine();
                check.IsValidName(Department);
                string id = "QM" + Department[0] + Designation.Substring(0, 3) + Name.Substring(0,1);
                employees.Add(new Employee(id, Name, Designation, email, Department));//Adding to the Employee list
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
            }
        }
        EmployeeDetails = JsonConvert.SerializeObject(employees);
        file.XmlFormatting(employees);//Method will write to Xml.
        file.JsonFormatting(EmployeeDetails);// Method will write to Json.
        //Console.WriteLine("Do you opt to send mail of the details press '1' or '0' "); 
        //Console.Write("Enter the receiver EmailId :  ");
        //string toMail = Console.ReadLine();
        //file.JsonList(toMail);
     }
}

