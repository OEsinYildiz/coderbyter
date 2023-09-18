using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Simple_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            bool SimpleSymbols(string str)
            {

                List<int> list = new List<int>(10);
                //bool result = true;
                for (int i = 0; i < str.Length; i++)
                {
                    if (Char.IsLetter(str[i]))
                    {
                        if (i ==0 || str[i-1]!= '+'  || str[i+1]!= '+')
                        {
                           return false;
                        }
                    }
                }

                return true;

                /*string pattern = @"[^\+]\+[a-zA-Z]\+[^\+]";
                Regex rg = new Regex(pattern);

                var match = rg.IsMatch(str);
                return match;*/

            }

            Console.WriteLine(SimpleSymbols("+d+=3=+s+"));
            Console.WriteLine(SimpleSymbols("f++d+"));
            Console.WriteLine(SimpleSymbols("b"));
        }
    }
}