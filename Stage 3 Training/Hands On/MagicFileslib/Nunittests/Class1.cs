using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicFileslib;
using Moq;

namespace Nunittests
{
    [TestFixture]
    public class Class1
    {
        private DirectoryExplorer _directory;
        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void Check()
        {
            var moqvariable = new Mock<DirectoryExplorer>();

            moqvariable.Setup(x => x.GetFiles(_file1)).Returns(()=> null);

            DirectoryExplorer dir = moqvariable.Object;

            var res = dir.GetFiles(_file1);

            Assert.That(res, Is.Null);
        }
    }
}
