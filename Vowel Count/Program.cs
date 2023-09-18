using System;
using System.Linq;

namespace Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string VowelCount(string str)
            {

                var vowel = new char[] {'a','e','i','o','u' };
                
                return str.Where(x => vowel.Contains(x)).Count().ToString();
                int count = 0;
                foreach (var item in str)
                {
                    if (vowel.Contains(item))
                    {
                        count++;
                    }
                }

                return count.ToString();
              
          

            }

            Console.WriteLine(VowelCount("hello"));
            Console.WriteLine(VowelCount("coderbyte"));
        }
    }
}