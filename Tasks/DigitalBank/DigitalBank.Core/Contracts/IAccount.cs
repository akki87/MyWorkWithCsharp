using DigitalBank.Core.Entities;

namespace DigitalBank.Core.Contracts
{
    internal interface IAccount
    {
        public decimal Balance { get; set; }
        public ulong Number { get; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }

        public static List<Transaction> transactions = new List<Transaction>();
        public bool Deposit(Amount amount, string note);
        public bool WithDraw(Amount amount, string note);
    }
}
