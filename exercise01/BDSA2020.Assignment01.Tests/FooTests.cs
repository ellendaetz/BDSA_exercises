
using Xunit;

namespace BDSA2020.Assignment01.Tests
{
    public class FooTests
    {
        [Theory]
        [InlineData("test123",true)]
        [InlineData("hej",true)]
        [InlineData("med",true)]
        [InlineData("dig",true)]
        public void Only_returns_true(string s, bool expected)
        {
            var f = new Foo(); 
            //act 
            var actual = f.Apply(s); 

            //assert
            Assert.Equal(expected, actual);  
        }

        [Theory]
        [InlineData("true", true)]
        [InlineData("This is false", false)]
        public void Returns_only_short_strings(string input, bool expected) 
        {
            //arrange
            var f = new Foo(); 

            //act
            var actual = f.ApplyOnlyIfShort(input); 

            //assert
            Assert.Equal(expected,actual); 
        }

        [Fact]
        public void Returns_true()
        {
            //arrange 
            string a = "hej"; 
            var f = new Foo();     

            //act
            var actual = f.Apply(a); 

            //assert 
            Assert.True(actual); 
        }
    }



}