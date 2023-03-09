namespace LinqOnEmployeeList
{
    public class Employee
    {
        public string Id { get; set; } 
        public string Name { get; set; }
        public string Department { get; set; }  
        public string Email { get; set; }   
        public Employee(string id, string name, string department, string email)
        {
            Id = id;
            Name = name;
            Department = department;
            Email = email;
        }
        public Employee() { }
    }
}