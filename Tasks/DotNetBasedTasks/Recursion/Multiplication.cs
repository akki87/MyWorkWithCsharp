namespace Recursion
{
    public class Multiplication
    {
        /// <summary>
        /// This is a iterative multiplication.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int IterativeMultiplication(int number1, int number2)
        {
            var result = (number1 > number2) ? number1 : number2;
            var limit = (number1 < number2) ? number1 : number2;
            for (int i = 1; i < number2; i++)
            {
                result += number1;
            }
            return result;
        }
        /// <summary>
        /// This is a recursie function which evaluate multiplication of two numbers.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public int RecursiveMultiplication(int number1, int number2)
        {
            if (number1 < number2)
            {
                return RecursiveMultiplication(number1,number2);
            }
            if (number2 == 0)
            {
                return 0;
            }
            else
            {
                return number1 + RecursiveMultiplication(number1, number2 - 1);
            }
        }

    }
}