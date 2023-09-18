using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Longest_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string LongestWord(string sen)
            {
                // code goes here
                var arr = sen.Split(' ');
                string pattern = @"^[a-zA-Z0-9]+$";
                Regex rg = new Regex(pattern);
                List<string> list = new List<string>();
                foreach (var element in arr)
                {
                    var newArr = rg.Match(element);
                    list.Add(newArr.Value);
                }

               var result = list.Aggregate((x, y) => x.Length >= y.Length ? x : y);
               return result;
            }

            Console.WriteLine(LongestWord("I love dogs"));
            Console.WriteLine(LongestWord("fun&!! time"));
        }
    }
}