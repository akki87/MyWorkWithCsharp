using System.Text;
using System.Configuration;
using Newtonsoft.Json;
using EmailSender;
using System.Xml.Linq;

namespace GenerateJSONFileForEmployees
{
    public class Employee
    {
        public string EmployeeId;
        public string EmployeeName;
        public string Designation;
        public string Email;
        public string Department;
        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="EmployeeId"></param>
        /// <param name="EmployeeName"></param>
        /// <param name="Designation"></param>
        /// <param name="Email"></param>
        /// <param name="Department"></param>
        public Employee(string EmployeeId, String EmployeeName, String Designation, String Email, String Department)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.Designation = Designation;
            this.Email = Email;
            this.Department = Department;
        }
    }
    public class Json
    {
        private List<Employee> empList;

        /// <summary>
        /// This method will write JsonStrings to the Json file
        /// </summary>
        /// <param name="EmployeeDetails"></param>
        internal void JsonFormatting(string EmployeeDetails)
        {
            string filepath = ConfigurationSettings.AppSettings["JsonPath"];
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            if (!File.Exists(filepath))
            {
                // Creating the same file if it doesn't exist
                using (StreamWriter sw = File.CreateText(filepath))
                { 
                    sw.WriteLine(EmployeeDetails.ToString());
                }
            }
        }
        public void JsonList(string ToMail)
        {
            string mail = ToMail;
            using (StreamReader r = new StreamReader(ConfigurationManager.AppSettings["path"]))
            {
                string json = r.ReadToEnd();
                Console.WriteLine(json);
                List<Employee> items = JsonConvert.DeserializeObject<List<Employee>>(json);
                StringBuilder body = new StringBuilder();
                body.Append(@"
             <!DOCTYPE html>
             <html lang=""en"">
             <head>
             <meta charset=""UTF-16"">
             <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
             <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
             </head>
             <style>
                    table{width:70%;margin:auto;background-color:white;border:1px solid grey;text-align:center;font-size:15px;font-weight:600;padding:6px;}
                    h1{color:blue;text-decoration: underline;}
                    p{padding:0px;color:grey;}
                    tr{color:black;background-color:grey;border:1px solid blue;}
             </style>
             <body>
             <h1>QM-BATCH-2-ASE</h1>
             <p>Including C# Full-stack and JavaScript Full-Stack</p>
             <table>
             <tr>
             <th>S.No</th>
             <th>EmployeeId</th>
             <th>Employee Name</th>
             <th>Designation</th>
             <th>Email</th>
             <th>Department</th>
             </tr>");
                int i = 0;
                foreach (Employee e in items)
                {
                    i++;
                    body.Append("<tr style=\"color:black;background-color:grey;border:1px solid blue;\"><td>" + i + "</td><td>" + e.EmployeeId + "</td><td>" + e.EmployeeName + "</td><td>" + e.Designation + "</td><td>" + e.Email + "</td><td>" + e.Department + "</td></tr>");
                }
                body.Append("</table></body></html>");
                Mail obj = new Mail();
                obj.SendMail(mail, body.ToString());
            }
        }
        public void XmlFormatting(List<Employee> employees)
        {
            string Filepath = ConfigurationManager.AppSettings["XmlPath"];
            try
            {
                var xEle = new XElement("Employees",
                            from emp in employees
                            select new XElement("Employee",
                                         new XElement("ID", emp.EmployeeId),
                                           new XElement("EmployeeName", emp.EmployeeName),
                                           new XElement("Designation", emp.Designation),
                                           new XElement("Email", emp.Email),
                                           new XElement("Department", emp.Department)
                                       ));
                xEle.Save(Filepath);
                Console.WriteLine("Converted to XML");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
