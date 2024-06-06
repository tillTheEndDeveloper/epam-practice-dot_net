﻿namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            ulong sum = 0;

            while (n != 0)
            {
                ulong digit = n % 10;
                sum += digit;
                n /= 10;
            }

            return sum;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            ulong sum = 1;

            if (n == 0)
            {
                sum = 0;
            }
            else
            {
                while (n > 0)
                {
                    sum *= n % 10;
                    n /= 10;
                }
            }

            return sum;
        }
    }
}
