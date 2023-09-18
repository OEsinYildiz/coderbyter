using System;
using System.Collections.Generic;
using System.Linq;

namespace ThreeFive_Multiples
{
    class Program
    {
        public static int ThreeFiveMultiples(int num) {

            // code goes here  
            List<int> list = new List<int>();
            for (int i = 1; i < num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0 )
                {
                    list.Add(i);
                }
            }
            
            return list.Sum();

        }

        static void Main() {  
            // keep this function call here
            Console.WriteLine(ThreeFiveMultiples(Console.ReadLine()));
        } 
    }
}