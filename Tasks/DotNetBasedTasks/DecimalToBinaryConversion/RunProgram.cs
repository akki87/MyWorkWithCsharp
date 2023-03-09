using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DecimalToBinaryConversions
{
    public class RunProgram
    {
        public static void Start(string[] args)
        {
            List<int> ints;
            DecimalToBinaryConversion Obj = new DecimalToBinaryConversion();
        code:
            try// Exception handling statements
            {
                Console.Write("Enter the Number: ");
                var number = Convert.ToDecimal(Console.ReadLine());
                ints = Obj.DecimalToBinary(number);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                goto code;// Jump Statements
            }
        Choice:
            Console.WriteLine("\n \tPress 1 To Continue\n \tPress 2 To Print\n \tPress 0 To Exit\n");
            var userchoice = Convert.ToInt32(Console.ReadLine());
            switch (userchoice)
            {
                case 0:
                    break;
                case 1:
                    ;   // Empty statement.
                    goto code;
                case 2:
                    Console.WriteLine(string.Join("", ints));
                    Console.WriteLine(ints.Count());
                    goto Choice;

            }
            if (4 < 0)// Unreachable Statement.
            {
                Console.WriteLine("I'll never get executed");
            }
        }
    }
}
