using System;
using System.Diagnostics;
using System.Linq;
using static System.Tuple;

namespace Switch_Sort
{
    class Program
    {
        public static int SwitchSort(int[] arr)
        {
            // code goes here  
            int count = 0;
            int[] newArr = new int[arr.Length];
            Array.Copy(arr, newArr, arr.Length);
            Array.Sort(newArr);
            if (arr[0] != arr.Min())
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Method(ref arr[i], ref arr[i + 1]);
                    //(arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    count++;
                    if (arr.Equals(newArr)) // Patlak
                        return count;
                }
            }
            else
            {
                for (int i = 1; i < arr.Length - 1; i++)
                {
                    Method(ref arr[i], ref arr[i + 1]);
                    count++;
                    if (arr.Equals(newArr))
                        return count;
                }
            }

            return count;
        }

        internal static void Method(ref int first, ref int second)
        {
            int x = first;
            first = second;
            second = x;
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(SwitchSort(new[] { 1, 4, 3, 2 }));
        }
    }
}