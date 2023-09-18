using System;
using System.Linq;

namespace Consecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            int Consecutive(int[] arr) {

                Array.Sort(arr);

                int min = arr.Min();
                int max = arr.Max();
                
                var result = Enumerable.Range(min, arr[^1]-arr[0]+1).Except(arr).Count();
                return result;

            }

            Console.WriteLine(Consecutive(new int[] {5,10,15}));
            Console.WriteLine(Consecutive( new int[] {-2,10,4}));
            Console.WriteLine(Consecutive( new int[] {4, 8, 6}));
        }
    }
}