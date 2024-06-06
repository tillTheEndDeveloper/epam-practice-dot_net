﻿using System;

namespace CountingStringChars
{
    public static class DoWhileMethods
    {
        /// <summary>
        /// Returns a number of digits in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of digits in a string.</returns>
        public static int GetDigitCount(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Returns a number of letters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of letters in a string.</returns>
        public static int GetLetterCount(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Returns a number of digits in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of digits in a string.</returns>
        public static int GetDigitCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetDigitCountRecursive(str, str.Length, 0);
        }

        /// <summary>
        /// Returns a number of letters in a string.
        /// </summary>
        /// <param name="str">A <see cref="string"/> to search.</param>
        /// <returns>A number of letters in a string.</returns>
        public static int GetLetterCountRecursive(string? str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            return GetLetterCountRecursive(str, str.Length, 0);
        }

        private static int GetDigitCountRecursive(string str, int charsLeft, int counter)
        {
            if (charsLeft > 0)
            {
                return GetDigitCountRecursive(str, charsLeft - 1, char.IsDigit(str[^charsLeft]) ? counter + 1 : counter);
            }

            return counter;
        }

        private static int GetLetterCountRecursive(string str, int charsLeft, int counter)
        {
            if (charsLeft > 0)
            {
                return GetLetterCountRecursive(str, charsLeft - 1, char.IsLetter(str[^charsLeft]) ? counter + 1 : counter);
            }

            return counter;
        }
    }
}
