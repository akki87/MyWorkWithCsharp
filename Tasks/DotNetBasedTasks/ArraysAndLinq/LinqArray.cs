namespace ArraysAndLinq
{
    /// <summary>
    /// This Class will return all numbers from an array,Even numbers and odd numbers from an array.
    /// </summary>
    public class LinqArray
    {
        public int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        /// <summary>
        /// This method will print all numbers in an array by using the input array.
        /// </summary>
        public void printAllNumbers()
        {
            Console.WriteLine("List of Numbers     : {0}", string.Join(",", array));
        }

        /// <summary>
        /// This method will print all even numbers present in an array.
        /// </summary>
        public void printEvenNumbers()
        {
            var evenNumbers = (from element in array
                               where element % 2 == 0
                               select element);
            Console.WriteLine("List of Even numbes : {0}", string.Join(",", evenNumbers));
        }

        /// <summary>
        /// This method will print all Odd numbers present in an array.
        /// </summary>
        public void printOddNumbers()
        {
            var oddNumbers = (from element in array
                              where element % 2 != 0
                              select element);
            Console.WriteLine("List of Even numbes : {0}", string.Join(",", oddNumbers));

        }

    }
}