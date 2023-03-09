

namespace DecimalToBinaryConversions
{
    public class DecimalToBinaryConversion
    {
        int i;     // Declaration statements
        List<int> a = new List<int>();
        public List<int> DecimalToBinary(decimal number)
        {
            for (i = 0; number != 0; i++)   // Iteration Statements
            {
                a.Add((int)number % 2);     // Expression statements.
                number = (int)number / 2;   // Embedded Statements.
            }
            a.Reverse();
            return a;    //jump statements.
        }
    }
}