﻿namespace IfStatements
{
    public static class Task3
    {
        public static bool DoSomething1(bool b)
        {
            var result = true;
            if (b)
            {
                result = false;
            }

            return result;
        }

        public static bool DoSomething2(bool b)
        {
            if (b)
            {
                return false;
            }

            return true;
        }
    }
}
