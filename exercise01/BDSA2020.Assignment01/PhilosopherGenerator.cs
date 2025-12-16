using System; 
namespace BDSA2020.Assignment01
{
    public class PhilosopherGenerator
    {
        public string Generate(char c)
        {
            if(c.Equals('n'))
            {
                return "Nietzsche"; 
            }
            else if (c.Equals('k'))
            {
                return "Kant";
            }
            else if (c.Equals('p'))
            {
                return "Plato";
            }
            else return "Nothing"; 
        }
    }
}