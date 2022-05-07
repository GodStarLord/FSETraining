using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SimpleCalculator;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CalculatorUnitTest
{
    [TestFixture]
    public class CalculatorTests
    {
        private BusinessLogic business;

        [SetUp]
        public void Init()
        {
            business = new BusinessLogic();
        }

        [Test]
        public void CheckAddition()
        {
            var result = business.Addition(5, 6);

                
            Assert.AreEqual((long)(5+6), result);
        }

        [TestCase(5, 6, ExpectedResult = 10)]
        public long AdditionCheck(long a, long b)
        {
            long result = business.Addition(a, b);

            return result;
        }

        [TestCase(6, 6, ExpectedResult = 0)]
        public long SubtractionCheck(long a, long b)
        {
            long result = business.Substraction(a, b);

            return result;
        }

        [Test]
        public void MultiplicationCheck()
        {
            var result = business.Multiplication(10, 20);

            Assert.AreEqual((long)(10*20),result);
        }

        [TestCase(10,5, ExpectedResult = (10/5))]
        public long DivisionCheck(long a, long b)
        {
            var result = business.Division(a, b);
            return result;
        }

        [TestCase(5, 2, ExpectedResult = (5 % 2))]
        public long ModulusCheck(long a, long b)
        {
            var result = business.Modulus(a, b);

            return result;
        }
    }
}
