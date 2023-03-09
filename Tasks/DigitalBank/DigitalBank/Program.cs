// See https://aka.ms/new-console-template for more information
using DigitalBank.Services;

public class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        Console.WriteLine("******************__Welcome To QualMinds Digital Bank__******************\n");
        new AccountServices();
    user:
        Console.Write("\n\n  Enter 1 To WithDraw \n  Enter 2 To Deposit  \n  Enter 3 For Transaction History\n  Enter 4 To Get Available Balance \n  Enter 0 To Exit\n\n");
        var choosenService = Convert.ToInt32(Console.ReadLine());
        switch (choosenService)
        {
            case 1:
                {
                    AccountServices.WithDraw();
                    goto user;
                }
            case 2:
                {
                    AccountServices.Deposit();
                    goto user;
                }
            case 3:
                {
                    AccountServices.GetTransactions();
                    goto user;
                }
            case 4:
                {
                    AccountServices.GetBalance();
                    goto user;
                }
            case 0:
                {
                    Console.WriteLine("Thank You....");
                    break;
                }
            default:
                {
                    break;
                }
        }
        watch.Stop();
        //Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }
}
