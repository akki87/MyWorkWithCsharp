// See https://aka.ms/new-console-template for more information
using QMDigitalBank;
using QMDigitalBank.Services;
internal class Program
{
    private static void Main(string[] args)
    {
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();
        Console.WriteLine("******************WELCOME TO QMDigital Bank******************");
        user:
        Console.Write("Select user type\n\n  'N' to create a new account \n  'E' for Existing customer \n");
        var choice = Convert.ToChar(Console.ReadLine());
        switch (choice)
        {
            case 'N':
                {
                    new AccountService();
                    goto user;
                    break;
                }
            case 'E':
                {
                    if (AccountService.UserService()) { goto user; }
                    break;
                }
                default:
                {
                    break; 
                }
        }
        watch.Stop();
        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }
}
 