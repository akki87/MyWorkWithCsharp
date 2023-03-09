using System.Text;
using DigitalBank.Core.Entities;

namespace DigitalBank.Extensions
{
    public static class TransactionExtensions
    {
        public static string GetTransactionHistory(this List<Transaction> transaction)
        {
            decimal balance = 0;
            string c = string.Empty;
            var str = new StringBuilder();
            str.AppendLine("Transaction Date\tTransaction Type\tAmount\tBalance\tCurrency\tTransaction Remarks.");
            foreach (Transaction t in transaction)
            {
                switch (t.Type)
                {
                    case TransactionType.Credit:
                        {
                            balance += t.Amount.Value;
                            c = "Cr";
                            break;
                        }
                    case TransactionType.Debit:
                        {
                            balance -= t.Amount.Value;
                            c = "Dr";
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                str.AppendLine($"{t.DateTime}\t{c}\t\t\t{t.Amount.Value}\t{balance}\t{"\u20B9"}\t\t{t.Note}");
            }
            return str.ToString();
        }
    }
}
