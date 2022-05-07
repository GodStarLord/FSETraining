using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFoodSupply;
using NUnit.Framework;

namespace FoodSupplyNUnit
{
    [TestFixture]
    public class Class1
    {
        private FoodDetail _foodDetail;
        private Program _program;

        [SetUp]
        public void Init()
        {
            _program = new Program();
            _foodDetail = _program.CreateFoodDetail("Biryani", 2, DateTime.Parse("10/11/2055"), 60);
        }

        [Test]
        [TestCase("Biryani", 2, "10/11/2022", 60)] //Successful creation
        [TestCase("", 2, "10/11/2022", 60)] //Empty value for food item name
        [TestCase("Biryani", 2, "10/11/2022", -60)] //Price less than 0
        [TestCase("Biryani", 2, "10/11/2019", 60)] //Expiry date less than current date
        public void CheckFoodObjectCreated(string name, int dishType, DateTime expiryDate, double price)
        {
            var foodDetails = _program.CreateFoodDetail(name, dishType, expiryDate, price);

            Assert.That(foodDetails, Is.InstanceOf<FoodDetail>());
        }

        [TestCase(2, "10/10/2022", "Hotel KJ", 15)] //Successful Creation
        [TestCase(-10, "10/10/2022", "Hotel KJ", 15)] //Food item count < 0
        [TestCase(2, "10/10/2020", "Hotel KJ", 15)] //Request Date < Current Date
        public void CheckSupplyDetailObjCreated(int count, DateTime requestDate, string supplierName,
            double packingCharge)
        {
            var foodDetails = _foodDetail;
            var supplyDetail =
                _program.CreateSupplyDetail(count, requestDate, supplierName, packingCharge, foodDetails);

            Assert.That(supplyDetail, Is.InstanceOf<SupplyDetail>());
        }

        [TestCase(2, "10/10/2022", "Hotel KJ", 15)]
        public void CheckSupplyDetailObjIsNull(int count, DateTime requestDate, string supplierName,
            double packingCharge)   //Null Object Creation
        {
            var supplyDetail =
                _program.CreateSupplyDetail(count, requestDate, supplierName, packingCharge, null);

            Assert.That(supplyDetail, Is.Null);
        }
    }
}
