using System;
using System.Collections.Generic;
using System.Linq;

namespace Three_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int Factorial(int x)
            {
                if (x == 0)
                {
                    return 1;
                }

                return x * Factorial(x - 1);
            }

            long Calculation(int n, int r)
            {
                if (n<r)
                {
                    return 0;
                }

                long numerator = Factorial(n);
                long denominator = Factorial(r);

                return numerator / denominator;
            }

            bool ThreeSum(int[] arr)
            {
                // code goes here 
                List<int> list = arr.ToList();
                int sum = list.First();
                list.Remove(sum);
                

                Random rnd = new Random();
                HashSet<int> set = new HashSet<int>();
                int r = 0;
                while (r < Calculation(list.Count , 3))
                {
                    int check = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        int rndNumber;
                        do
                        {
                            rndNumber = rnd.Next(list.Count);
                        } while (set.Contains(rndNumber));

                        check += list[rndNumber];

                        if (sum == check)
                        {
                            return true;
                        }
                    }

                    r++;
                }

                return false;
                
            }
            
            
            Console.WriteLine(ThreeSum(new int[] {10, 2, 3, 1, 5, 3, 1, 4, -4, -3, -2}));
            Console.WriteLine(ThreeSum(new int[] {12, 3, 1, -5, -4, 7}));
            Console.WriteLine(ThreeSum(new int[] {8, 2, 1, 4, 10, 5, -1, -1}));
        }
    }
}