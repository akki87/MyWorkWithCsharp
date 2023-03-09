using RMS.BusinessLogics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        RMSCodeFirstApproach.RunProgram.Start(args);
		RunBusiness.Start(args);

	}
}