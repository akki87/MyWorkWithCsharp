using DigitalBank.Core.Contracts;

namespace DigitalBank.Core.Entities
{
    public class Account : IAccount
    {
        public ulong Number { get; private set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }

        private static ulong s_AccountNumber = 1000000000000000;
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }

        }
        private decimal _balance;
        public static List<Transaction> transactions = new List<Transaction>();
        public Account() { }

        public Account(string firstName, string lastname, decimal Amount)
        {
            if (Amount < 500)
            {
                throw new ArgumentOutOfRangeException("","Opening Balance amount must be more the 500 or equal");
            }
            Amount amount = new Amount();
            OwnerFirstName = firstName;
            OwnerLastName = lastname;
            Number = s_AccountNumber;
            amount.Value = Amount;
            Deposit(amount, "opening balance");
            s_AccountNumber++;
        }

        public bool Deposit(Amount amount, string note)
        {
            if (amount.Value <= 0)
            {
                throw new ArgumentOutOfRangeException("","Deposit amount cannot be less than or equal to zero");
            }
            _balance = Balance + amount.Value;
            Transaction transaction = new Transaction()
            {
                DateTime = DateTime.Now,
                Type = TransactionType.Credit,
                Amount = amount,
                Note = note,
            };
            transactions.Add(transaction);
            Console.WriteLine($"Rs{amount.Value} is Deposited Successfully");
            return true;
        }

        public bool WithDraw(Amount amount, string note)
        {
            if (amount.Value <= 0)
            {
                throw new ArgumentOutOfRangeException("","Invalid amount, Enter valid amount and try again");
            }
            if (Balance - amount.Value < 0)
            {
                throw new InvalidOperationException("Transaction failed!!, Insufficient balance.");
            }
            _balance -= amount.Value;
            Transaction transaction = new Transaction()
            {
                DateTime = DateTime.Now,
                Type = TransactionType.Debit,
                Amount = amount,
                Note = note,
            };
            transactions.Add(transaction);
            Console.WriteLine($"You were withdrawn Rs {amount.Value}");
            return true;
        }
    }
}
