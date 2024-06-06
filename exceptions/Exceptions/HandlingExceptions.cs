﻿namespace Exceptions
{
    public static class HandlingExceptions
    {
        public static bool CatchArgumentOutOfRangeException1(int i, Func<int, bool> foo)
        {
            if (foo is null)
            {
                throw new ArgumentNullException(nameof(foo));
            }

            try
            {
                return foo(i);
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
        }

        public static string CatchArgumentOutOfRangeException2(int i, object o, string s, out string errorMessage)
        {
            errorMessage = null;

            try
            {
                return DoSomething(i, o, s);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                errorMessage = ex.Message;
                return "K139";
            }
        }

        public static string CatchArgumentNullException3(object o, Func<object, string> foo)
        {
            if (foo is null)
            {
                throw new ArgumentNullException(nameof(foo));
            }

            try
            {
                return foo(o);
            }
            catch (ArgumentNullException)
            {
                return "P456";
            }
        }

        public static string CatchArgumentNullException4(int i, object o, string s, out string errorMessage)
        {
            errorMessage = null;

            try
            {
                return DoSomething(i, o, s);
            }
            catch (ArgumentNullException ex)
            {
                errorMessage = ex.Message;
                return "A732";
            }
        }

        public static int CatchArgumentException5(int[] integers, Func<int[], int> foo)
        {
            if (foo is null)
            {
                throw new ArgumentNullException(nameof(foo));
            }

            try
            {
                return foo(integers);
            }
            catch (ArgumentException)
            {
                return 0;
            }
        }

        public static string CatchArgumentException6(int i, object o, string s, out string errorMessage)
        {
            errorMessage = null;

            try
            {
                return DoSomething(i, o, s);
            }
            catch (ArgumentException ex)
            {
                errorMessage = ex.Message;
                return "D948";
            }
        }

        public static string CatchArgumentException7(int i, object o, string s, out string errorMessage)
        {
            errorMessage = null;

            try
            {
                return DoSomething(i, o, s);
            }
            catch (ArgumentNullException ex)
            {
                errorMessage = ex.Message;
                return "W694";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                errorMessage = ex.Message;
                return "Z029";
            }
            catch (ArgumentException ex)
            {
                errorMessage = ex.Message;
                return "J954";
            }
        }

        public static string DoSomething(int i, object o, string s)
        {
            if (i < -10 || i > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(i), "i should be in [-10, 10] interval.");
            }

            if (o is null)
            {
                throw new ArgumentNullException(nameof(o), "o is null.");
            }

            if (s is null)
            {
                throw new ArgumentNullException(nameof(s), "s is null.");
            }

            if (s.Length == 0)
            {
                throw new ArgumentException("s string is empty.", nameof(s));
            }

            return $"{i}{o}{s}";
        }
    }
}
