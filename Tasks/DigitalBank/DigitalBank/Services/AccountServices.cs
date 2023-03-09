using DigitalBank.Core.Entities;
using DigitalBank.Extensions;

namespace DigitalBank.Services
{
    internal class AccountServices
    {
        public static Account Obj = new Account();
        public AccountServices()
        {
        UserRegistration:
            try
            {
                Console.WriteLine("Please enter your details to create your bank account\n\n");
                Console.Write("Enter your First name:   ");
                string? firstName = Console.ReadLine();
                Console.Write("Enter your Last name:   ");
                string? lastName = Console.ReadLine();
            Useramount:
                try
                {
                    Console.Write("Please provide intial deposit amount:  ");
                    decimal amount = Convert.ToInt32(Console.ReadLine());
                    Obj = new Account(firstName, lastName, amount);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    goto Useramount;
                }
                Console.WriteLine($" Congratulations {Obj.OwnerFirstName},Thank you for opening an account with us.\n");
            }
            catch (ArgumentException ee)
            {
                Console.WriteLine(ee.Message);
                goto UserRegistration;
            }
        }
        public static void GetBalance() { Console.WriteLine($"Available balance is {Obj.Balance}"); }

        public static void Deposit()
        {
            Amount a = new Amount();
        DAmount:
            try
            {
                Console.Write("Enter Deposit amount:   ");
                a.Value = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter note:  ");
                string? note = Console.ReadLine();
                Obj.Deposit(a, note);    
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                goto DAmount;
            }
        }

        public static void WithDraw()
        {
            Amount a = new Amount();
        WAmount:
            try
            {
                Console.Write("Enter amount to be withdraw:   ");
                a.Value = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter note:  ");
                string? note = Console.ReadLine();
                Obj.WithDraw(a, note);    
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                goto WAmount;
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                goto WAmount;
            }
        }
        public static void GetTransactions()
        {
            Console.WriteLine(TransactionExtensions.GetTransactionHistory(Account.transactions));
        }

    }
}
