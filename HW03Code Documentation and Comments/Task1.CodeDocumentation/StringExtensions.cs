// ********************************
// <copyright file="StringExtensions.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>
//
// ********************************

namespace Task1.CodeDocumentation
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;


    /// <summary>
    /// Contains extension methods for the <see cref="System.String"/> class
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Encoding string with MD5 Hash algorithm
        /// </summary>
        /// <param name="input">Input string to encode</param>
        /// <returns>Returns encoded string</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Check if string value is a "true" - kind value (i.e. "ok", "true", "да" etc.) 
        /// </summary>
        /// <param name="input">Input string to convert</param>
        /// <returns>Returns the <see cref="System.Boolean"/> equivalent of the string</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };

            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Convert string type value to <see cref="System.Int16"/> (short type) value;
        /// </summary>
        /// <param name="input">Input string to convert</param>
        /// <returns>Returns the converted to <see cref="System.Int16"/> string</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);

            return shortValue;
        }

        /// <summary>
        /// Convert string to <see cref="System.Int32"/>(integer) value;
        /// </summary>
        /// <param name="input">Input string to convert</param>
        /// <returns>Returns the converted to <see cref="System.Int32"/> string</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Convert string type value to <see cref="System.Int64"/>(long) type value
        /// </summary>
        /// <param name="input">Input string to convert</param>
        /// <returns>Returns the converted to <see cref="System.Int64"/> string</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Convert string type value to DateTime type value
        /// </summary>
        /// <param name="input">Input string to convert</param>
        /// <returns>Returns the converted to <see cref="System.DateTime"/> string</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);

            return dateTimeValue;
        }

        /// <summary>
        /// Capitalize first letter of a string value
        /// </summary>
        /// <param name="input">Input string to capitalize the first letter</param>
        /// <returns>String with capitalized first letter</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Get substring between two given strings
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="startString">Starting string</param>
        /// <param name="endString">Ending string</param>
        /// <param name="startFrom">Index to start from</param>
        /// <returns>Returns the requested string or <paramref name="endString"/> if no such exists</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Convert cyrillic to latin letters
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Returns the latin string representation of the given <paramref name="input"/></returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Convert latin letters string to cyrillic letters string
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Returns the cyrillic string representation of the given <paramref name="input"/></returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Converts a given input string to a valid username 
        /// by converting cyrillic letters to there latin representations and 
        /// removing any non-alphanumeric characters (except '.')
        /// </summary>
        /// <param name="input">The input username string</param>
        /// <returns>Returns valid username</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();

            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts a given input string to a valid file name
        /// by converting cyrillic letters to there latin representations
        /// and replacing all spaces with hyphens. Any non-alphanumeric characters are removed 
        /// (except '.' and '-')
        /// </summary>
        /// <param name="input">The input filename string</param>
        /// <returns>Returns valid filename string</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();

            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Gets a substring with given amount of characters from the beginning of a string
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="charsCount">Number of characters to be included in the substring</param>
        /// <returns>Returns the given amount of characters substring</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Get file extension from a file name
        /// </summary>
        /// <param name="fileName">Input filename string</param>
        /// <returns>Returns file extension</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Converts a given file extension to appropriate content type
        /// </summary>
        /// <param name="fileExtension">The input file extension</param>
        /// <returns>Returns the converted content type</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts input string to byte array
        /// </summary>
        /// <param name="input">Input string to be converted</param>
        /// <returns>Returns byte array</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);

            return bytesArray;
        }

        /// <summary>
        /// Main method
        /// </summary>
        public static void Main()
        {
            string input = "Ala bala";
            string encodedString = ToMd5Hash(input);
            Console.WriteLine(encodedString);

            string ok = "ok";
            bool isTrue = ToBoolean(ok);
            Console.WriteLine(isTrue);

            string shortNumberAsString = "12345";
            short convertedShortNumber = ToShort(shortNumberAsString);
            Console.WriteLine(convertedShortNumber);

            string intNumberAsString = "1234567890";
            int convertedIntNumber = ToInteger(intNumberAsString);

            string longNumberAsString = "9223372036854775807";
            long convertedLongNumber = ToLong(longNumberAsString);

            string dateTime = "12.02.2015";
            DateTime convertedDateTime = ToDateTime(dateTime);
            Console.WriteLine(convertedDateTime);

            string stringForCapitalize = "alabalanica";
            string capitalizedFirstLetter = CapitalizeFirstLetter(stringForCapitalize);
            Console.WriteLine(capitalizedFirstLetter);

            string substringBala = GetStringBetween(capitalizedFirstLetter, "Ala", "nica");
            Console.WriteLine(substringBala); // bala

            string substringAla = GetFirstCharacters(capitalizedFirstLetter, 3);
            Console.WriteLine(substringAla); // Ala
        }
    }
}