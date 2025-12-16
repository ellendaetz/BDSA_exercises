using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment01
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            List<string> names = new List<string>(); 

            //only people with last name Daetz
            String pattern = @"(([A-Z][a-z]*) )*([D][a][e][t][z])+"; 
            Regex reg = new Regex(pattern); 
            
            foreach (String s in lines)
            {
                if(Regex.IsMatch(s, pattern)==true)
                {
                    names.Add(s); 
                }
            }

            return names; 
        }

        public static bool Is_Daetz(String name)
        {
            String pattern = @"(([A-Z][a-z]*) )*([D][a][e][t][z])+"; 

            var valid = Regex.IsMatch(name,pattern);
            
            return valid; 
        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }
    }
}
