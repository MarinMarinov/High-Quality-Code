namespace Exceptions_Homework
{
    using System.Text;

    public class StringExtractor
    {
        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length)
            {
                return "Invalid count!";
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }
    }
}