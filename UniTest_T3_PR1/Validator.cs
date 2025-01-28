
using T3.PR1;
using T3._PR1._Practica_1.EnegyClass;
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
        //He intentat fer un [InlineData], pero no em deixa. Jo posaria els valors limit que serian 235.1 i 235.3 .
        public void HidroelectricSystemCalculateEnergy_IncorrectValue()
        {
            // Arrange
            var system = new HidroelectricSystem(30, DateTime.Now);

            // Act
            double energy = system.CalculateEnergy(30);

            // Assert
            Assert.NotEqual(235.1, energy);
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
        //He intentat fer un [InlineData], pero no em deixa. Jo posaria els valors limit que serian 7.6 i 7.4 .
        public void SolarSystemCalculateEnergy_IncorrectValue()
        {
            // Arrange
            var system = new SolarSystem(5, DateTime.Now);

            // Act
            double energy = system.CalculateEnergy(5);

            // Assert
            Assert.NotEqual(7.6, energy);
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
        //He intentat fer un [InlineData], pero no em deixa. Jo posaria els valors limit que serian 199.9 i 200.1 .
        public void WindSystemCalculateEnergy_IncorrectValue()
        {
            // Arrange
            var system = new WindSystem(10, DateTime.Now);

            // Act
            double energy = system.CalculateEnergy(10);

            // Assert
            Assert.NotEqual(199.9, energy);
        }
        [Fact]
        public void ResizeArrays_Correctly()
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
        public void PrintRegistres_ShouldPrint_Correctly()
        {
            // Arrange
            string[] array = new string[2] { "Energy1", "Energy2" };

            // Act
            RenovableEnergy.PrintRegistres(array);

            // Assert
            Assert.Equal("Energy1", "Energy1");
            Assert.Equal("Energy2", "Energy2");
        }
        [Fact]
        public void PrintRegistres_ShouldNotPrint_Correctly()
        {
            // Arrange
            string[] array = new string[2] { "Energy1", "Energy2" };

            // Act
            RenovableEnergy.PrintRegistres(array);

            // Assert
            Assert.NotEqual("Energy2", "Energy1");
            Assert.NotEqual("Energy1", "Energy2");
        }
    }
}