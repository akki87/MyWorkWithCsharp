namespace EmployeeSalaryCalculator
{
    public class SCalculator:EmployeeSalaryCalculator
    {

        public override string SalaryCalculator(string fullName,string employeeType,decimal workingDuration)
        {
            decimal salary = 0;
            switch (employeeType)
            {
                case "Permanent":
                    {
                        salary = (decimal)(2000 * workingDuration);
                        break;
                    }
                case "Temporary":
                    {
                        salary = (decimal)(200 * workingDuration);
                        break;
                    }
            }
            return $"\nEmpName: {fullName}\nEmpType: {employeeType}\nPrice: {salary} Rs.\n";
        }
    }
}
