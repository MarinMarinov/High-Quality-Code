using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        string raw = string.Empty;
        long[] parsedRaw = new long[0];
        long[] sequenceOfAbsolluteDifference = new long[0];
        bool isDecreasing = false;
        List<bool> results = new List<bool>();

        for (int i = 1; i <= t; i++)
        {
            raw = Console.ReadLine();
            parsedRaw = ParseRaw(raw);
            sequenceOfAbsolluteDifference = FindSequenceOfAbsoluteDifference(parsedRaw);
            isDecreasing = IsSequenceDecreasing(sequenceOfAbsolluteDifference);
            results.Add(isDecreasing);
        }

        foreach (bool answer in results)
        {
            Console.WriteLine(answer);
        }
    }

    private static long[] ParseRaw(string raw)
    {
        string[] rawOfNumbersAsString = raw.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        long[] rawOfParsedNumbers = new long[rawOfNumbersAsString.Length];

        for (int i = 0; i < rawOfNumbersAsString.Length; i++)
        {
            rawOfParsedNumbers[i] = long.Parse(rawOfNumbersAsString[i]);
        }

        return rawOfParsedNumbers;
    }

    private static long[] FindSequenceOfAbsoluteDifference(long[] raw)
    {
        long[] sequenceOfDifferences = new long[raw.Length - 1];
        long difference = 0;

        for (var i = 0; i < raw.Length - 1; i += 1)
        {
            difference = Math.Abs(raw[i] - raw[i + 1]);
            sequenceOfDifferences[i] = difference;
        }

        return sequenceOfDifferences;
    }

    private static bool IsSequenceDecreasing(long[] sequence)
    {
        bool isDecreasing = false;

        if (sequence.Length == 1)
        {
            isDecreasing = true;
        }

        for (int i = 0; i < sequence.Length - 1; i++)
        {
            long firstNumber = sequence[i];
            long secondNumber = sequence[i + 1];

            if (firstNumber >= secondNumber && (Math.Abs(firstNumber - secondNumber) <= 1))
            {
                isDecreasing = true;
            }
            else
            {
                isDecreasing = false;
                break;
            }
        }

        return isDecreasing;
    }
}