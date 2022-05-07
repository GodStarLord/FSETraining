using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using PlayersManagerLib;

namespace NunitTest
{
    [TestFixture]
    public class Class1
    {
        [SetUp]
        public void Init()
        {

        }

        [Test]
        public void checkPlayer()
        {
            List<Player> players = new List<Player>
            {
                new Player("Ron", 20, "USA", 10),
                new Player("Lance", 22, "UK", 15)
            };

            var dbSet = new Mock<DbSet<Player>>();

            var queriableData = players.AsQueryable();

            dbSet.As<IQueryable<Player>>().Setup(emp => emp.Provider).Returns(queriableData.Provider);
            dbSet.As<IQueryable<Player>>().Setup(emp => emp.Expression).Returns(queriableData.Expression);
            dbSet.As<IQueryable<Player>>().Setup(emp => emp.ElementType).Returns(queriableData.ElementType);
            dbSet.As<IQueryable<Player>>().Setup(emp => emp.GetEnumerator()).Returns(queriableData.GetEnumerator());

            var moq = new Mock<Player>();

        }
    }
}
