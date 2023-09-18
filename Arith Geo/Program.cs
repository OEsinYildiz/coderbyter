using System;
using System.Linq;

namespace Arith_Geo
{
    class Program
    {
        static void Main(string[] args)
        {
            string ArithGeo(int[] arr)
            {
                string result = string.Empty;
                int sum = arr.Sum();

                int ave = (arr[0] + arr[arr.Length-1]) / 2;
                int checkAve = sum / arr.Length;

                int ratio = arr[1] / arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] != arr[0] * Math.Pow(ratio, i))
                    {
                        result = "-1";
                        if (ave==checkAve)
                        {
                            result = "Arithmetic";
                        }
                    }
                    else
                    {
                        result = "Geometric";
                    }
                }

                return result;
            }

            Console.WriteLine(ArithGeo(new int[] { 5, 10, 15 }));
            Console.WriteLine(ArithGeo(new int[] { 2, 6, 18, 54}));
        }
    }
} 