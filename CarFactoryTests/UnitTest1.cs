

using CarFactory.Factories;

namespace CarFactoryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpelSportsCarTest()
        {
            //Arrange
            var sportsCarFactory = new SportsCarFactory();
            var description = "I'm Opel sports car";
            //Act
            var OpelSportsCar = sportsCarFactory.CreateOpel();
            //Assert
            Assert.AreEqual(description, OpelSportsCar.CarDescription());
        }

        [TestMethod]
        public void FiatSportsCarTest()
        {
            //Arrange
            var sportsCarFactory = new SportsCarFactory();
            var description = "I'm Fiat sports car";
            //Act
            var fiatSportsCar = sportsCarFactory.CreateFiat();
            //Assert
            Assert.AreEqual(description, fiatSportsCar.CarDescription());
        }

        [TestMethod]
        public void OpelVanTest()
        {
            //Arrange
            var vanFactory = new VanFactory();
            var description = "I'm Opel van";
            //Act
            var opelVan = vanFactory.CreateOpel();
            //Assert
            Assert.AreEqual(description, opelVan.CarDescription());
        }

        [TestMethod]
        public void FiatVanTest()
        {
            //Arrange
            var vanFactory = new VanFactory();
            var description = "I'm Fiat van";
            //Act
            var fiatVan = vanFactory.CreateFiat();
            //Assert
            Assert.AreEqual(description, fiatVan.CarDescription());
        }
    }
}