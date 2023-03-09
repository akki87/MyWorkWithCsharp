using System;
using DigitalBank.Business.Contracts;
using DigitalBank.Business.Entities;
using QMDigitalBank.Extensions;

namespace QMDigitalBank.Services
{
    internal class AccountService
    {

        public AccountService()
        {
            var Obj = new Account();
        UserRegistration:
            try
            {
                Console.WriteLine("Enter your details to create your bank account");
                Console.Write("Please Enter your First name:   ");
                string? firstName = Console.ReadLine();
                Console.Write("Please Enter your Last name:   ");
                string? lastName = Console.ReadLine();
            Useramount:
                try
                {
                    Console.Write("Please provide intial deposit amount:   ");
                    decimal amount = Convert.ToInt32(Console.ReadLine());
                    Obj = new Account(firstName, lastName, amount);
                    CreatingAccount(Obj);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    goto Useramount;
                }
                Console.WriteLine($" Congratulations!!,On opening account with us {Obj.OwnerFirstName}, with opening balance of {Obj.Balance}");
                Console.WriteLine("Please keep this user ID for further operations : {0}", Obj.AccountID);
            }
            catch(ArgumentException ee)
            {
                Console.WriteLine(ee.Message);
                goto UserRegistration;
            }
            void CreatingAccount(Account obj)
            {
                //Account Obj = new Account(firstName, lastName, amount);
                Account.customers.Add(obj);
            }

        }
        public static  bool UserService()
        {
            Console.Write("Enter your USER ID(generated at registration time) before proceed :  ");
            int userId = Convert.ToInt32(Console.ReadLine());
            var account = Account.customers.Find(e => e.AccountID == userId);
            transactionChoice:
            Console.Write("Select transaction type\n\n  'd' to Deposit the amount\n  'w' to Withdraw the amount\n  't' for transactions\n");
            var choosenService = Convert.ToChar(Console.ReadLine());
            switch (choosenService)
            {
                case 'd':
                    {
                        Deposit(userId);
                        goto transactionChoice;
                        break;
                    }
                case 'w':
                    {
                        WithDraw(userId);
                        goto transactionChoice;   
                    }
                case 't':
                    {
                        transactionshistory(userId);
                        goto transactionChoice;   
                    }
                default:
                    {
                        return true;
                    }
            }
            void transactionshistory(int userid)
            {
                Console.WriteLine(TransactionExtensions.GetTransactionHistory(Account.Transactions[userId]));
            }
        }

        public static  void Deposit(int userid)
        {

            var account = Account.customers.Find(e => e.AccountID == userid);
            Amount a = new Amount();
        DAmount:
            try
            {
                Console.Write("Enter your amount:   ");
                a.Value = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter note:  ");
                string? note = Console.ReadLine();
                account.Deposit(a, note);
            }
            catch(ArgumentOutOfRangeException  e)
            {
                Console.WriteLine(e.Message);
                goto DAmount;
            }
        }
        public static  void WithDraw(int userid)
        {
            Amount a = new Amount();
            var account = Account.customers.Find(e => e.AccountID == userid);   
        WAmount:
            try
            {
                Console.Write("Enter amount to be withdraw:   ");
                a.Value = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter note:  ");
                string? note = Console.ReadLine();
                account.WithDraw(a, note);

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                goto WAmount;
            }

        }

    }
}
