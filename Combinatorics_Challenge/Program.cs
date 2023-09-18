using System;
using System.Collections.Generic;

namespace Combinatorics_Challenge
{
    class Program
    {
        public static int CombinatoricsChallenge(int num,List<(int, int)> list )
        {
            // code goes here  
            //int firstStep = 1;
            if (num == 2)
            {
                return 1;
            }
            

            for (int i = 1; i < num; i++)
            {
                list.Add((CombinatoricsChallenge(num - i, list), CombinatoricsChallenge(i, list)));
            }
            
            return list.Count;
            
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(CombinatoricsChallenge(4, new List<(int, int)>()));
        }
    }
}