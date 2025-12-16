using Xunit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;  

namespace BDSA2020.Assignment01.Tests
{
    public class SequencesTests
    {
        [Theory]
        [InlineData(0,0)]
        [InlineData(8, 21)]
        [InlineData(20,6765)]
        public void return_Fibonacci_number(int input, long expected)
        {
            //act
            var actual = Sequences.Fibonacci(input); 

            //assert 
            Assert.Equal(expected, actual);
            Assert.Throws<ArgumentException>(() => Sequences.Fibonacci(-1)); 
        }

        [Fact]
        public void Sequences_invalid_input_throws()
        {
            int i = -1; 
            var actual = Assert.Throws<ArgumentException>(() => Sequences.Fibonacci(i)); 

            Assert.Equal("only positive n within range", actual.Message); 
        }

    }
}