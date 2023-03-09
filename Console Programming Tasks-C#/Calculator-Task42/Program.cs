// See https://aka.ms/new-console-template for more information
using Calculator;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" CALCULATOR ");
        operations obj = new operations();
        double Number1 = 0;
        double Number2 = 0;
        int action = 0;
        while (true)
        {
            try
            {
                Console.WriteLine("Enter first Number");
                Number1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                obj.Errortext(e.Message.ToString());
                continue;
            }
            try
            {
                Console.WriteLine("Enter Second Number");
                Number2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                obj.Errortext(e.Message.ToString());
                continue;
            }
            try
            {
                Console.WriteLine("Enter action (Addition :1 || Subtraction : 2 || Multiplication : 3 || Division : 4)");
                action = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                obj.Errortext(e.Message.ToString());
                continue;
            }
            switch (action)
            {
                case 1:
                    {
                        Console.WriteLine("The result is {0}", obj.Addition(Number1, Number2));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The result is {0}", obj.Subtraction(Number1, Number2));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("The result is {0}", obj.Multiplication(Number1, Number2));
                        break;
                    }
                case 4:
                    {
                        if (obj.Division(Number1, Number2) == -1) 
                        { 
                            Console.WriteLine("Cannot be divided by a zero exception");
                            obj.Errortext("DivideByZeroException");
                        }
                        else 
                        { 
                            Console.WriteLine("The result is {0}", obj.Division(Number1, Number2)); 
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Select valid case");
                        break;
                    }


            }
            Console.WriteLine("---------------------------------------------");
        }
    }
}