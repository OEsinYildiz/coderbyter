using System;
using System.Text.RegularExpressions;

namespace AB_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            string ABCheck(string str) {

                // code goes here  

                string pattern = @"a...b|b...a";
                Regex regx = new Regex(pattern);
                Match m = regx.Match(str);
    
                //Console.WriteLine(m.Success);
    

                return m.Success.ToString().ToLower();

            }

            Console.WriteLine(ABCheck("after badly"));
            Console.WriteLine(ABCheck("Laura sobs"));
        }
    }
}