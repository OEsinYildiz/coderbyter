using System;

namespace Alphabet_Soup
{
    class Program
    {
        static void Main(string[] args)
        {
            string AlphabetSoup(string str) {

                // code goes here  
                var arr = str.ToCharArray();
                Array.Sort(arr);
                return String.Join("", arr);
         

            }

            Console.WriteLine(AlphabetSoup("coderbyte"));
            Console.WriteLine(AlphabetSoup("hooplah"));
        }
    }
}