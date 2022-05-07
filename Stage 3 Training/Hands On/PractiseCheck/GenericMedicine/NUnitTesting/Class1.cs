using System;
using GenericMedicine;
using NUnit.Framework;

namespace NUnitTesting
{
    [TestFixture]
    public class Class1
    {
        private Program _program;
        private Medicine _medicine;

        [SetUp]
        public void Init()
        {
            _program = new Program();
            _medicine = _program.CreateMedicineDetail("Dolo 650", "Paracetamol", "Paracetamol 650", DateTime.Parse("02/02/2022"),
                10);
        }


        [TestCase("Dolo 650", "Paracetamol", "Paracetamol 650","02/02/2022",
            10)] //Pass
        [TestCase("Montair LC", "Paracetamol", "Paracetamol 650", "02/02/2021",
            10)] //Expiry date less than current date
        [TestCase("Remilyn D", "", "Paracetamol 650", "02/02/2022",
            10)] //Empty value for generic medicine name
        [TestCase("Dolo 650", "", "Paracetamol 650", "20/02/2022",
            -5)] //price per strip < 0
        public void MedicineTest(string name, string genericMedicineName, string composition, DateTime expiryDate,
            double pricePerStrip)
        {
            Medicine medicine =
                _program.CreateMedicineDetail(name, genericMedicineName, composition, expiryDate, pricePerStrip);

            Assert.That(medicine, Is.InstanceOf<Medicine>());

        }

        [TestCase(3, "03/02/2021", "SK Nagar, Banglore")] //Pass
        [TestCase(0, "03/02/2021", "SK Nagar, Banglore")] //Strip count < 0
        [TestCase(3, "02/02/2021", "SK Nagar, Banglore")] //launch date less than current date
        public void CartonTest(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var medicine = _medicine;
            var carton = _program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, medicine);

            Assert.That(carton, Is.InstanceOf<CartonDetail>());
        }

        [TestCase(3, "03/02/2021", "SK Nagar, Banglore")]
        public void CartonTestIsNull(int medicineStripCount, DateTime launchDate, string retailerAddress)
        {
            var carton = _program.CreateCartonDetail(medicineStripCount, launchDate, retailerAddress, null);

            Assert.That(carton, Is.Null);
        }

        //[Test]
        //public void ObjectTest()
        //{
        //    Medicine medicine = _program.CreateMedicineDetail("Dolo 650", "Paracetamol", "Paracetamol 650", DateTime.Parse("02/02/2022"),
        //        10);

        //    Assert.That(medicine, Is.InstanceOf<Medicine>());
        //    //Assert.IsNotNull(medicine);
        //}
    }
}
