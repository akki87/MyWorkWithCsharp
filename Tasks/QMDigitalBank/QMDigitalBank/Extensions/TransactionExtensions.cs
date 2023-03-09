using System;
using System.Collections.Generic;
using System.Text;
using DigitalBank.Business.Entities;

namespace QMDigitalBank.Extensions
{
    internal static  class TransactionExtensions
    {

        public static  string GetTransactionHistory(this List<Transaction> transaction)
        {
            decimal balance = 0;
            var str = new StringBuilder();
            str.AppendLine("Date\t\t\tAmount\tCurrency\tBalance\tType\tNote");
            foreach(Transaction t in transaction)
            {
                switch(t.Type)
                {
                    case TransactionType.Credit:
                        {
                            balance += t.Amount.Value;
                            break;
                        }
                    case TransactionType.Debit:
                        {
                            balance -= t.Amount.Value;
                            break;
                        }
                }
                str.AppendLine($"{t.DateTime}\t{t.Amount.Value}\t{t.Amount.Currency}\t\t{balance}\t{t.Type}\t{t.Note}");
            }
            return str.ToString();
        }

    }
}
