using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DigitalBank.Business.Entities
{
    public  class Transaction
    { 
        public DateTime DateTime { get; set; }
        public Amount Amount { get; set;}
        public TransactionType Type { get; set; }
        public string? Note { get; set; }
       


    }
    public struct Amount
    {
        public decimal Value;
        public Currency Currency;
    }
    public enum Currency
    {
        INR,
        USD,
        GBP
    }
    public enum TransactionType
    {
        Credit,
        Debit
    }
}
