
namespace BDSA2020.Assignment01
{
    public class Foo : IFoo
    {
        public bool Apply(string input)
        {
            return true; 
        }

        public bool ApplyOnlyIfShort(string input)
        {
            if(input.Length <= 5)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }
    }

}