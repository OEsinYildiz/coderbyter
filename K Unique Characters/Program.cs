using System;
using System.Collections.Generic;
using System.Linq;

namespace K_Unique_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string KUniqueCharacters(string str)
            {
                var k = Convert.ToInt32(str.Substring(0, 1));
                str = str.Substring(1);
                int length = k;
                List<string> list = new List<string>();

                while (length < str.Length)
                {
                    for (int i = 0; i <= str.Length-length; i++)
                    {
                        string subString = str.Substring(i, length);
                        if (subString.Distinct().Count() == k)
                        {
                            list.Add(subString);
                        }
                    }

                    length++;
                }
                
                // code goes here  
                return list.Aggregate((x, y) => x.Length >= y.Length ? x : y);
            }

            Console.WriteLine(KUniqueCharacters("3aabacbebebe"));
            Console.WriteLine(KUniqueCharacters("2aabbcbbbadef"));
        }
    }
}