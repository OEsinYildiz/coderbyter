using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Two_Sum
{
    class Program
    {
        public static string TwoSum(int[] arr)
        {
            // code goes here
            var newList = new List<int>();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 1; i < arr.Length; i++)
            {
                int sum = arr[0] - arr[i];
                if (arr.Contains(sum) && !newList.Contains(sum) && !sum.Equals(arr[i]))
                {
                    newList.Add(arr[i]);
                    newList.Add(sum);
                    stringBuilder.Append(arr[i]);
                    stringBuilder.Append(',');
                    stringBuilder.Append(sum);
                }
            }
            

            if (newList.Count < 1)
            {
                return "-1";
            }

            return stringBuilder.ToString().Trim();
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(TwoSum(Console.ReadLine()));
        }
    }
}