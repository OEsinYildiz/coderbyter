using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            int SimpleMode(int[] arr)
            {
                
                HashSet<int> hashSet = new HashSet<int>();
                Dictionary<int, int> dictionary = new Dictionary<int, int>();
                //int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!hashSet.Contains(arr[i]))
                    {
                        dictionary.Add(arr[i], 1);
                        hashSet.Add(arr[i]);
                    }
                    else
                    {
                        dictionary[arr[i]] += 1;
                    }
                }

               
                var maxKey = dictionary.Aggregate((x, y) => x.Value >= y.Value ? x : y).Key;
                if (dictionary[maxKey] == 1)
                {
                    return -1;
                }
                return maxKey ;
            }

            Console.WriteLine(SimpleMode(new []{5,5,2,2,1}));
            Console.WriteLine(SimpleMode(new []{3,4,1,6,10}));
        }
    }
}