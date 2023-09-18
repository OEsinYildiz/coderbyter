using System;
using System.Collections.Generic;
using System.Linq;

namespace Wave_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int WaveSorting(int[] arr)
            {
                int mdl = (arr.Length + 1)/ 2;
                return mdl;
            }
            Console.WriteLine(WaveSorting(new int[] {0, 4, 22, 4, 14, 4}));
        }
    }
}