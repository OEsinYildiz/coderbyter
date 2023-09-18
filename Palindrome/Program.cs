using System;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Palindrome(string str) {

                // code goes here  
                var newStr = Regex.Replace(str, @"\s+", "");
                var arr = newStr.ToCharArray();
                var reverse = new Char[arr.Length];
                Array.Copy(arr,reverse, arr.Length);
                Array.Reverse(reverse);
                
                string first = string.Concat(arr);
                string second = string.Concat(reverse);

                return first == second;
            }
            
           Console.WriteLine(Palindrome("never odd or even"));
           Console.WriteLine(Palindrome("racecar"));
            Console.WriteLine(Palindrome("rotor plus three"));
        } 
    }
}