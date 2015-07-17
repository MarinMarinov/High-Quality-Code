namespace Task01.BoolToStringConverter
{
    using System;

    public class BoolToStringConverter
    {
        public static string ConvertBoolToString(bool value)
        {
            string stringVariable = value.ToString();

            return stringVariable;
        }

        static void Main()
        {
            bool booleanVariable = true;
            string booleanAsString = ConvertBoolToString(booleanVariable);

            Console.WriteLine(booleanAsString);
        }
    }
}
