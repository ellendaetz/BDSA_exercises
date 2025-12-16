
using Xunit;

namespace BDSA2020.Assignment01.Tests
{
    public class PhilosopherTests
    {
        [Theory]
        [InlineData('n', "Nietzsche")]
        [InlineData('p', "Plato")]
        [InlineData('k', "Kant")]
        [InlineData('y', "Nothing")]
        public void Char_generate_string(char input, string expected)
        {
            //Arrange
            PhilosopherGenerator p = new PhilosopherGenerator(); 

            //Act
            var actual = p.Generate(input); 
            
            //Assert
            Assert.Equal(expected, actual); 
        }
    }
}