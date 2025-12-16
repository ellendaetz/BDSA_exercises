using System; 

namespace BDSA2020.Assignment01
{
    public class Bar{
        
        public bool Cocktail(string input)
        {
            if(input.Equals("Old Fashioned"))
            {
                return true; 
            } 
            else if (input.Equals("Screwdriver"))
            {
                return false; 
            }
            else
            {
                throw new ArgumentException("Cocktail is not in database");
            }
        } 
    }
}