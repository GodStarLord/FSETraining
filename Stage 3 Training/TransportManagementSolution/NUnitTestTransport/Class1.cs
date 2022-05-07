using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  NUnit.Framework;
using TransportManagementBLLibrary;

namespace NUnitTestTransport
{
    [TestFixture]
    public class Class1
    {
        private bool _check { get; set; }
        private BusinessLogic businessLogic;

        [SetUp]
        public void Init()
        {
            _check = true;
            businessLogic = new BusinessLogic();
        }

        [Test]
        public void MyCheck()
        {
            Assert.IsTrue(_check);
        }

        [Test]
        //[TestCase(100)] //here 100 is passed as parameter to the below function
        [TestCase(100, ExpectedResult = 100)]
        //this is the TestCase
        [TestCase(101, ExpectedResult = 101)]
        //[TestCase(ExpectedValue, ActualValue)]
        public int TestCase2(int num) //Changed to int for 2nd test case
        {
            var result = businessLogic.TestCheck();

            //Assert.AreEqual(num, result);

            //return result;

            return num;
        }

        [Test]
        public void UsernameCheck()
        {
            Assert.That(businessLogic.userName, Is.EqualTo("admin"));
        }

        [Test]
        public void PasswordCheck()
        {
            Assert.That(businessLogic.passWord, Is.EqualTo("admin2"));
        }
    }
}
