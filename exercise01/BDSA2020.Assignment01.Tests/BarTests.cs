using System;
using Xunit; 

namespace BDSA2020.Assignment01.Tests
{
    public class BarTests
    {
        [Theory]
        [InlineData("Old Fashioned", true)]
        [InlineData("Screwdriver", false)]
        public void Is_cocktail_or_not(string input, bool expected)
        {
            //arrange
            Bar bar = new Bar(); 

            //act
            var actual = bar.Cocktail(input);

            //assert
            Assert.Equal(expected, actual);
        
        }

        [Fact]
        public void Coctail_is_not_in_database()
        {
            Bar bar = new Bar(); 

            var actual = Assert.Throws<ArgumentException>(() => bar.Cocktail("Something")); 

            Assert.Equal("Cocktail is not in database", actual.Message); 
        }
    }
}