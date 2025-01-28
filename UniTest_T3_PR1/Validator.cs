
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
        [Fact]
        public void ResizeArraysCorrectly()
        {
            // Arrange
            string[] array = new string[2] { "Energy1", "Energy2" };
            int newSize = 2;

            // Act
            string[] resizedArray = RenovableEnergy.ResizeArrays(ref array, newSize);

            // Assert
            Assert.Equal(4, resizedArray.Length);
        }
        [Fact]
        public void PrintRegistres_ShouldPrintCorrectly()
        {
            // Arrange
            var arrayRegistres = new string[2] { "Entry1", "Entry2" };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                RenovableEnergy.PrintRegistres(arrayRegistres);

                // Assert
                var result = sw.ToString();
                Assert.Contains("Entry1", result);
                Assert.Contains("Entry2", result);
            }
        }
    }
}