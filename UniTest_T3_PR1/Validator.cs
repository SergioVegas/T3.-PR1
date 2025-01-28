
using System;
using T3.PR1;
using T3._PR1._Pràctica_1.EnegyClass;
using T3._PR1.EnergyClasses;
namespace UniTest_T3_PR1
{
    public class Validator
    {
        [Fact]
      
        public void HidroelectricSystemCalculateEnergy_CorrectValue()
        {
            // Arrange
            var system = new HidroelectricSystem(30, DateTime.Now);

            // Act
            double energy = system.CalculateEnergy(30);

            // Assert
            Assert.Equal(235.2, energy);
        }

        [Fact]

        public void SolarSystemCalculateEnergy_CorrectValue()
        {
            // Arrange
            var system = new SolarSystem(5, DateTime.Now);

            // Act
            double energy = system.CalculateEnergy(5);

            // Assert
            Assert.Equal(7.5, energy);
        }
        [Fact]

        public void WindSystemCalculateEnergy_CorrectValue()
        {
            // Arrange
            var system = new WindSystem(10, DateTime.Now);

            // Act
            double energy = system.CalculateEnergy(10);

            // Assert
            Assert.Equal(200, energy);
        }
    }
}