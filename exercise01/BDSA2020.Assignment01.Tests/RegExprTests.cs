using Xunit;
using System.Collections.Generic;

namespace BDSA2020.Assignment01.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void Test_Pattern()
        {
            List<string> lines = new List<string>(){
                "Ellen Daetz",
                "Jes Klausby", 
                "Birgit Charlotte Daetz", 
                "Gisela K Daetz",
                "Daetz", 
                "ellen daetz"
            }; 

            var actual = RegExpr.SplitLine(lines); 
            
            var expected = new List<string>(){
                "Ellen Daetz",
                "Birgit Charlotte Daetz", 
                "Gisela K Daetz",
                "Daetz"
            }; 

            Assert.Equal(expected, actual); 
        }

    }
}
