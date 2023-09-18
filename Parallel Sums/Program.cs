using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parallel_Sums
{
    class Program
    {
        public static string ParallelSums(int[] arr)
        {
            // code goes here
            List<int> newArr = arr.ToList();
            List<int> result = new List<int>();
            List<int[]> listArray = new List<int[]>();
            Stack<int> currentList = new Stack<int>();

            BuildListOfSubsets(arr, listArray, arr.Length / 2, 0, currentList);
            foreach (var list in listArray)
            {

                if (list.Sum().Equals(arr.Sum() / 2))
                {
                    newArr.RemoveAll(x => list.Contains(x));
                    result= SortAndCombine(newArr.ToArray(), list.ToArray()).ToList();
                    break;
                }
                /*foreach (var item in list)
                {
                    newArr.Remove(item);
                    if (newArr.Sum().Equals(list.Sum()))
                    {
                        result= SortAndCombine(newArr.ToArray(), list.ToArray()).ToList();
                    }
                }*/
            }

            return String.Join(',', result);
        }

        private static void BuildListOfSubsets(int[] originalList, List<int[]> listOfSubsets, int sizeOfSubsetList, int currentLevel, Stack<int> currentList)
        {
            if (currentList.Count == sizeOfSubsetList)
            {
                int[] copy = new int[sizeOfSubsetList];
                currentList.CopyTo(copy, 0);
                listOfSubsets.Add(copy);
            }
            else
                for (int ix = currentLevel; ix < originalList.Length; ix++)
                {
                    currentList.Push(originalList[ix]);
                    BuildListOfSubsets(originalList, listOfSubsets, sizeOfSubsetList, ix + 1, currentList);
                    currentList.Pop();
                }
        }

        static int[] SortAndCombine(int[] arr1, int[] arr2)
        {
            Array.Sort(arr1);
            Array.Sort(arr2);
            if (arr1[0]>arr2[0])
            {
                return arr2.Union(arr1).ToArray();
            }
            else
            {
                return arr1.Union(arr2).ToArray();
            }
            
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(ParallelSums(new int[] {9,1,0,5,3,2}));
        }
    }
}