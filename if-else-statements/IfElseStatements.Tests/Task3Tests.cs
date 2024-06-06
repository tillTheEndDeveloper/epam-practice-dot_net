﻿using NUnit.Framework;

namespace IfStatements.Tests
{
    [TestFixture]
    public class Task3Tests
    {
        [TestCase(true, 0, ExpectedResult = 1)]
        [TestCase(true, 1, ExpectedResult = 2)]
        [TestCase(true, 2, ExpectedResult = 3)]
        [TestCase(true, 3, ExpectedResult = 4)]
        [TestCase(true, 4, ExpectedResult = 5)]
        [TestCase(true, 5, ExpectedResult = 6)]
        [TestCase(true, 6, ExpectedResult = 7)]
        [TestCase(true, 7, ExpectedResult = 8)]
        [TestCase(true, 8, ExpectedResult = 9)]
        [TestCase(true, 9, ExpectedResult = 10)]
        [TestCase(true, 10, ExpectedResult = 11)]
        [TestCase(true, -1, ExpectedResult = 0)]
        [TestCase(true, -2, ExpectedResult = -1)]
        [TestCase(true, -3, ExpectedResult = -2)]
        [TestCase(true, -4, ExpectedResult = -3)]
        [TestCase(true, -5, ExpectedResult = -4)]
        [TestCase(true, -6, ExpectedResult = -16)]
        [TestCase(true, -7, ExpectedResult = -17)]
        [TestCase(true, -8, ExpectedResult = -18)]
        [TestCase(true, -9, ExpectedResult = -19)]
        [TestCase(true, -10, ExpectedResult = -20)]
        [TestCase(false, 0, ExpectedResult = -1)]
        [TestCase(false, 1, ExpectedResult = 0)]
        [TestCase(false, 2, ExpectedResult = 1)]
        [TestCase(false, 3, ExpectedResult = 2)]
        [TestCase(false, 4, ExpectedResult = 3)]
        [TestCase(false, 5, ExpectedResult = 4)]
        [TestCase(false, 6, ExpectedResult = 5)]
        [TestCase(false, 7, ExpectedResult = 6)]
        [TestCase(false, 8, ExpectedResult = 18)]
        [TestCase(false, 9, ExpectedResult = 19)]
        [TestCase(false, 10, ExpectedResult = 20)]
        [TestCase(false, -1, ExpectedResult = -2)]
        [TestCase(false, -2, ExpectedResult = -3)]
        [TestCase(false, -3, ExpectedResult = -4)]
        [TestCase(false, -4, ExpectedResult = -5)]
        [TestCase(false, -5, ExpectedResult = -6)]
        [TestCase(false, -6, ExpectedResult = -7)]
        [TestCase(false, -7, ExpectedResult = -8)]
        [TestCase(false, -8, ExpectedResult = -9)]
        [TestCase(false, -9, ExpectedResult = -10)]
        [TestCase(false, -10, ExpectedResult = -11)]
        public int DoSomething1_ReturnsInteger(bool b, int i)
        {
            return Task3.DoSomething1(b, i);
        }

        [TestCase(true, 0, ExpectedResult = 1)]
        [TestCase(true, 1, ExpectedResult = 2)]
        [TestCase(true, 2, ExpectedResult = 3)]
        [TestCase(true, 3, ExpectedResult = 4)]
        [TestCase(true, 4, ExpectedResult = 5)]
        [TestCase(true, 5, ExpectedResult = 6)]
        [TestCase(true, 6, ExpectedResult = 7)]
        [TestCase(true, 7, ExpectedResult = 8)]
        [TestCase(true, 8, ExpectedResult = 9)]
        [TestCase(true, 9, ExpectedResult = 10)]
        [TestCase(true, 10, ExpectedResult = 11)]
        [TestCase(true, -1, ExpectedResult = 0)]
        [TestCase(true, -2, ExpectedResult = -1)]
        [TestCase(true, -3, ExpectedResult = -2)]
        [TestCase(true, -4, ExpectedResult = -3)]
        [TestCase(true, -5, ExpectedResult = -4)]
        [TestCase(true, -6, ExpectedResult = -16)]
        [TestCase(true, -7, ExpectedResult = -17)]
        [TestCase(true, -8, ExpectedResult = -18)]
        [TestCase(true, -9, ExpectedResult = -19)]
        [TestCase(true, -10, ExpectedResult = -20)]
        [TestCase(false, 0, ExpectedResult = -1)]
        [TestCase(false, 1, ExpectedResult = 0)]
        [TestCase(false, 2, ExpectedResult = 1)]
        [TestCase(false, 3, ExpectedResult = 2)]
        [TestCase(false, 4, ExpectedResult = 3)]
        [TestCase(false, 5, ExpectedResult = 4)]
        [TestCase(false, 6, ExpectedResult = 5)]
        [TestCase(false, 7, ExpectedResult = 6)]
        [TestCase(false, 8, ExpectedResult = 18)]
        [TestCase(false, 9, ExpectedResult = 19)]
        [TestCase(false, 10, ExpectedResult = 20)]
        [TestCase(false, -1, ExpectedResult = -2)]
        [TestCase(false, -2, ExpectedResult = -3)]
        [TestCase(false, -3, ExpectedResult = -4)]
        [TestCase(false, -4, ExpectedResult = -5)]
        [TestCase(false, -5, ExpectedResult = -6)]
        [TestCase(false, -6, ExpectedResult = -7)]
        [TestCase(false, -7, ExpectedResult = -8)]
        [TestCase(false, -8, ExpectedResult = -9)]
        [TestCase(false, -9, ExpectedResult = -10)]
        [TestCase(false, -10, ExpectedResult = -11)]
        public int DoSomething2_ReturnsInteger(bool b, int i)
        {
            return Task3.DoSomething2(b, i);
        }
    }
}
