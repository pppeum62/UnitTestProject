using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void T01_더하기()
        {
            int a = 5;
            int b = 5;
            int c = a + b;

            int expected = 10;

            Assert.AreEqual(expected, c, "더하기 연산 실패!");
        }

        [TestMethod]
        public void T02_빼기()
        {
            int a = 10;
            int b = 5;
            int c = a - b;

            int expected = 5;

            Assert.AreEqual(expected, c, "빼기 연산 실패!");
        }

        [TestMethod]
        public void T03_1부터_10까지_더하기()
        {
            int result = 0;

            for(int i = 1; i < 11; i++)
            {
                result += i;
            }

            int expected = 55;

            Assert.AreEqual(expected, result, "더하기 연산 실패!");
        }
    }
}
