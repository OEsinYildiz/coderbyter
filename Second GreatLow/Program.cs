using System;
using System.Linq;

namespace Second_GreatLow
{
    class Program
    {
        static void Main(string[] args)
        {
            string SecondGreatLow(int[] arr)
            {
                Array.Sort(arr);
                if (arr.Length == 2)
                {
                    return $"{arr[0]} {arr[1]}";
                }
                int min = arr.Min();
                int max = arr.Max();

                int lowest = arr.Where(x => x > min).First();
                int greatest = arr.Where(x => x < max).Last();
                
                // code goes here  
                return $"{lowest} {greatest}";

            }

            Console.WriteLine(SecondGreatLow(new []{80,80}));
        }
    }
}