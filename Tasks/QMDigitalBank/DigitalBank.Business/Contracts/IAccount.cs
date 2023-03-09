using System;
using DigitalBank.Business.Entities;

namespace DigitalBank.Business.Contracts
{
    public interface IAccount
    {
        public decimal Balance { get; set; }
        public ulong Number { get;}
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public static Dictionary<int, List<Transaction>> Transactions = new Dictionary<int, List<Transaction>>();
        public bool Deposit(Amount amount, string note);
        public bool WithDraw(Amount amount, string note);
    }
}
