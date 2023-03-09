namespace StringCompressor
{
    public class Compressor
    {

        public string testData;
        public Compressor(string testString)
        {
            this.testData = testString;
        }

        /// <summary>
        /// This method will take a string as parameter and return the compressed version of the string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        public static string CompressString(string str)
        {
            int Count = 1;

            string result = String.Empty;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    Count += 1;
                    if (i + 1 == str.Length - 1)
                    {
                        result += str[i] + Count.ToString();
                    }
                }
                else if (str[i] != str[i + 1])
                {
                    result += str[i] + Count.ToString();
                    Count = 1;
                }
                else
                {
                    result += str[i] + Count.ToString();
                    Count = 1;
                }
            }
            return result;
        }

    }
}