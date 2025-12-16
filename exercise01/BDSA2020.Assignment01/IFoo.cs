using System; 

namespace BDSA2020.Assignment01
{
    public interface IFoo
    {
        bool Apply(string input);
        bool ApplyOnlyIfShort(string input); 
    }; 
};
