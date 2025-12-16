using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace BDSA2020.Assignment01.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Test_Flatten_ListList()
        {
            //arrange
            List<List<int>> input = new List<List<int>>(){
                new List<int>(){1,2},
                new List<int>(){3,4}
            }; 
            
            List<List<string>> input1 = new List<List<string>>(){
                new List<string>(){"Jeg","hedder","Ellen"},
                new List<string>(){"og", "er","21",""}
            };

            //act
            IEnumerable<int> actualInt = Iterators.Flatten(input); 
            IEnumerable<string> actualString = Iterators.Flatten(input1); 
            var expected = new List<string>(){"Jeg","hedder","Ellen","og", "er","21",""}; 

            //assert 
            Assert.Equal(new List<int>(){1,2,3,4},actualInt); 
            Assert.Equal(expected,actualString); 
        }

        [Fact]
        public void Test_Filter()
        {
            //arrange
            Predicate<int> isEven = IsEven;
            List<int> input = new List<int>(){2,4,6}; //doesnt break
            List<int> input1 = new List<int>(){2,3,4,5,6,7}; //break when 3 
            List<int> input2 = new List<int>(){1,4,5}; //break when 1 and returns empty list 

            //act 
            var actual = Iterators.Filter(input, IsEven); 
            var actual1 = Iterators.Filter(input1, IsEven); 
            var actual2 = Iterators.Filter(input2, IsEven); 

            //assert 
            Assert.Equal(new List<int>{2,4,6}, actual); 
            Assert.Equal(new List<int>{2}, actual1); 
            Assert.Equal(new List<int>(){}, actual2); 
        }

        public static bool IsEven(int i)
        {
            return i % 2 == 0;
        }

        [Fact]
        public void IterationIntegers()
        {
            //Arrange           
            List<int> list = new List<int>(){6}; 

            //Act
            IEnumerable<int> actual = Iterators.Flatten1(list); 
        
            //Assert
            Assert.Equal(new List<int>(){6},actual); 
        }   

        [Fact]
        public void IterationStrings()
        {
            List<string> list = new List<string>(){"Hej","med","dig"}; 

            IEnumerable<string> actual = Iterators.Flatten1(list); 

            Assert.Equal(new List<string>(){"Hej","med","dig"}, actual);
        }

        [Theory]
        [InlineData(4,5,9)]
        [InlineData(20,20,40)]
        [InlineData(0,0,0)]
        [InlineData(-2,4,2)]
        [InlineData(-2,-2,-4)]
        public void Addition(int x, int y, int output)
        {
            //arranage is inlinedata 

            //act 
            var expected = Iterators.AddToNumbers(x,y); 

            //assert
            Assert.Equal(expected,output); 
        }
 
    }
}
