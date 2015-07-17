using System;
using System.Collections.Generic;
using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> input = new List<string>(Console.ReadLine().Split(' '));

        Console.WriteLine(ConvertDecimalTo26(ConvertSeventeenToDecimal(input)));
    }

    public static string ConvertDecimalTo26(List<BigInteger> outputDecimal)
    {
        List<string> outputIn26 = new List<string>();

        List<string> digits = new List<string>();

        // Filling the list with the letters form a to z
        for (char i = 'a'; i <= 'z'; i++)
        {
            digits.Add(i.ToString());
        }

        for (int i = 0; i < outputDecimal.Count; i++)
        {
            string result = string.Empty;
            do
            {
                result = digits[(int)(outputDecimal[i] % 26)] + result;
                outputDecimal[i] = outputDecimal[i] / 26;

            }
            while (outputDecimal[i] > 0);

            outputIn26.Add(result);            
        }

        string output = string.Join(" ", outputIn26.ToArray());

        return output;
    }

    public static List<BigInteger> ConvertSeventeenToDecimal(List<string> input)
    {
        List<BigInteger> outputDecimal = new List<BigInteger>();
        int digit = 0;

        foreach (string word in input)
        {
            BigInteger decimalNumber = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] >= 'a' && word[i] <= 'z')
                {
                    digit = word[i] - 'a';
                }

                decimalNumber += (BigInteger)(digit * Math.Pow(17, word.Length - i - 1));
            }

            outputDecimal.Add(decimalNumber);
        }

        return outputDecimal;
    }
}