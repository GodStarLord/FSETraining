using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Customercomm;
using Moq;
using NUnit.Framework;

namespace CustomerNUnit
{
    [TestFixture]
    public class Class1
    {
        private MailSender _sender;

        [SetUp]
        [OneTimeSetUp]
        public void Init()
        {
            _sender = new MailSender();
        }

        [Test]
        public void TestMail()
        {
            Mock<MailSender> moq = new Mock<MailSender>();

            moq.Setup(x => x.SendMail("customer@gmail.com", "Some Message")).Returns(true);

            var customer = new CustomerComm(moq.Object);

            Assert.AreEqual(true, customer.SendMailToCustomer());
        }
    }
}
