using System;
using System.Text.RegularExpressions;

namespace Even_Pairs
{
    class Program
    {
        public static bool EvenPairs(string str)
        {
            // code goes here  
            return Matches(str);
        }

        private static bool Matches(string str)
        {
            string regex = @"\d?[02468]\d?[02468]"; 
            var response = Regex.Match(str, regex).Value;
            if (response.Length>=2)
            {
                return true;
            }

            return false;
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(EvenPairs(Console.ReadLine()));
        }
    }
}