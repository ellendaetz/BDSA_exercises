using System;
using System.Collections.Generic;

namespace BDSA2020.Assignment01
{
    public class Iterators
    {
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            List<T> output = new List<T>();

            foreach (IEnumerable<T> list in items)
            {
                foreach (var t in list)
                {
                    output.Add(t); 
                }
            }

            return output; 
        }

        public static IEnumerable<T> Flatten1<T>(IEnumerable<T> items)
        {
            List<T> output = new List<T>();

            foreach(T t in items)
            {
                output.Add(t); 
            }
            return output; 
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {
            foreach (var item in items)
            {
                if(predicate(item)) 
                {
                    Console.Write(item); 
                    yield return item;
                } 
                else 
                {
                    yield break;
                }  
            }
        }
        
        public static int AddToNumbers(int x, int y)
        {
            return x + y;
        }  
    }
}
