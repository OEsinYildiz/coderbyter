using System;
using System.Collections.Generic;
using System.Linq;

namespace String_Challneg
{
    class Program
    {
        public static string StringChallenge(string str) {

            // code goes here  
            var arr = str.Split();
            List<string> list = new List<string>();
            foreach (var item in arr)
            {
                list.Add(item.Substring(0,1).ToUpper()+item.Substring(1));
            }
            
            return String.Join(' ',list);

        }

        static void Main() {  
            // keep this function call here
            Console.WriteLine(StringChallenge(Console.ReadLine()));
        } 
    }
}