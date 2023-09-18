using System;
using System.Linq;

namespace Consonant_Count
{
    class Program
    {
        public static string ConsonantCount(string str) {

            // code goes here 
            int result =str.Length; 
            char[] arr = {'a','e','i','o','u',' '};
            
            for(int i=0; i<str.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (str[i] == arr[j])
                        result--;
                }
            }
            return result.ToString();

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(ConsonantCount(Console.ReadLine()));
        }
    }
}