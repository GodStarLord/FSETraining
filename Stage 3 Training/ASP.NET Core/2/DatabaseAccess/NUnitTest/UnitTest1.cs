using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using DatabaseAccess.Controllers;
using DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]  //Simple MOQ
        public void CheckTheCheckTestMOQ()
        {
            //Arrange
            var moqContext = new Mock<CompanyContext>();

            moqContext.Setup(x => x.Checks).Returns("Hello");

            //Action
            EmployeeController employeeController = new EmployeeController(moqContext.Object);

            //Assert
            Assert.AreEqual(true, employeeController.CheckTheCheck());
        }

        [Test]
        public void GetEmployeeTestForFirstEmployee()
        {
            //Arrange 
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Somu"},
                new Employee() {Id = 2, Name = "Ramu"}
            };

            //Mock for Dbset of employees
            var dbSetMoq = new Mock<DbSet<Employee>>(); //setup dummy database

            //Setting up the DbSet<Employee> moq
            var queriableData = employees.AsQueryable();
            dbSetMoq.As<IQueryable<Employee>>().Setup(emp => emp.Provider).Returns(queriableData.Provider);
            dbSetMoq.As<IQueryable<Employee>>().Setup(emp => emp.Expression).Returns(queriableData.Expression);
            dbSetMoq.As<IQueryable<Employee>>().Setup(emp => emp.ElementType).Returns(queriableData.ElementType);
            dbSetMoq.As<IQueryable<Employee>>().Setup(emp => emp.GetEnumerator()).Returns(queriableData.GetEnumerator());

            //Context for moq
            var moqContext = new Mock<CompanyContext>();

            //setting up moq for context
            moqContext.Setup(x => x.Employees).Returns(dbSetMoq.Object);

            //Action
            EmployeeController employeeController = new EmployeeController(moqContext.Object);

            //Assert
            Assert.AreEqual("Somu", employeeController.GetEmployees()[0].Name);
        }
    }
}