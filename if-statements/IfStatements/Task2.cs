﻿namespace IfStatements
{
    public static class Task2
    {
        public static int DoSomething1(int i)
        {
            var result = i;

            if (i < 0 && i >= -5)
            {
                result = 0 - i;
            }

            if (i < -5)
            {
                result = 0 - (i * i);
            }

            return result;
        }

        public static int DoSomething2(int i)
        {
            if (i < 0 && i >= -5)
            {
                return 0 - i;
            }

            if (i < -5)
            {
                return 0 - (i * i);
            }

            return i;
        }
    }
}
