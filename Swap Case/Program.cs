using System;
using System.Collections.Generic;
using System.Linq;

namespace Swap_Case
{
    class Program
    {
        public static string SwapCase(string str)
        {
            // code goes here  

            var lowerLetter = Enumerable.Range('A', 26).Select(x => (char)x).ToList();
            var upperLetter = Enumerable.Range('a', 26).Select(x => (char)x).ToList();
            char[] arr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if (lowerLetter.Contains(str[i]))
                {
                    arr[i] = upperLetter[lowerLetter.IndexOf(str[i])];
                }
                else if (upperLetter.Contains(str[i]))
                {
                    arr[i] = lowerLetter[upperLetter.IndexOf(str[i])];
                }
                else{
                    arr[i]=str[i];
                }
            }

            var test = String.Concat(arr);
            return str;
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(SwapCase(Console.ReadLine()));
        }
    }
}