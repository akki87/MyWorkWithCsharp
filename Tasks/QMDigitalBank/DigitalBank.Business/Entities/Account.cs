using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalBank.Business.Contracts;

namespace DigitalBank.Business.Entities
{
    public class Account:IAccount
    {
        // <summary>
        /// Data members Account number,Owner First name, Owner last name,Balance.
        /// </summary>
        public int AccountID
        {
            get { return _AccountID; }
            set { _AccountID = value; }
        }
        private int _AccountID;
        public ulong Number { get; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }

        private static ulong s_AccountNumber = 1000000000000000;
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }

        }
        private decimal _balance;
        /// <summary>
        /// List of transaction made on an account.
        /// </summary>
        public static Dictionary<int, List<Transaction>> Transactions = new Dictionary<int, List<Transaction>>();

        public static List<Account> customers = new List<Account>();
        public Account() { }
       
        public Account(string firstName, string lastname,decimal Amount)
        {
            if (Amount < 500)
            {
                throw new ArgumentOutOfRangeException(nameof(Amount), "Opening Balance amount must be more the 500 or equal");
            }
            Amount amount = new Amount();
            OwnerFirstName = firstName;
            OwnerLastName = lastname;
            Number = s_AccountNumber;
            _AccountID = IdGenerator();
            amount.Value = Amount;
            Deposit(amount, "opening balance");
            s_AccountNumber++;

        }

        public bool Deposit(Amount amount, string note)
        {
            if (amount.Value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount cannot be less than or equal to zero");
            }
            _balance = Balance + amount.Value;
            Transaction transaction = new Transaction()
            {
                DateTime = DateTime.Now,
                Type = TransactionType.Credit,
                Amount =   amount,
                Note = note,
            };
            if (Transactions.ContainsKey(_AccountID))
            {
                Transactions[_AccountID].Add(transaction);
            }
            else
            {
                Transactions.Add(_AccountID, new List<Transaction>());
                Transactions[_AccountID].Add(transaction);
                Console.WriteLine(_AccountID);
            }
            return true;
        }


        public bool WithDraw(Amount amount, string note)
        {
            if (amount.Value <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot be zero");
            }
            if (Balance - amount.Value < 0)
            {
                throw new InvalidOperationException("Withdraw amount cannot exceed than available balance");
            }
            _balance -= amount.Value;
            Transaction transaction = new Transaction()
            {
                DateTime = DateTime.Now,
                Type = TransactionType.Debit,
                Amount = amount,
                Note = note,
            };
            if (Transactions.ContainsKey(_AccountID))
            {
                Transactions[_AccountID].Add(transaction);
                Console.WriteLine("Added to {0}", _AccountID);
            }
            else
            {
                Transactions.Add(_AccountID, new List<Transaction>());
                Transactions[_AccountID].Add(transaction);
                Console.WriteLine(_AccountID);
            }
            return true;
        }
        private int IdGenerator()
        {
            Random rnd = new Random();
            return (int)rnd.Next();
        }
    }
}
