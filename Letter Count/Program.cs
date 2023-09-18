using System;
using System.Collections.Generic;
using System.Linq;

namespace Letter_Count
{
    class Program
    {
        public static string LetterCount(string str)
        {
            
            //Todo: Geliştirilmesi gerekir. O(n) olmalı. 
            // code goes here  
            //List<char> list = new List<char>();
            var arr = str.Split(' ');
            List<int> resultIndex = new List<int>();
            int equal = 0;
            foreach (var word in arr)
            {
                if (word.Equals(String.Concat(word.Distinct().ToList())))
                    equal++;
                int count = 1;
                var test = word.Distinct();
                var f = word.Length - word.Distinct().Count();
                resultIndex.Add(f);

                #region OldCode

                /*for (int i = 0; i < word.Length; i++)
                {
                    
                    if (list.Contains(word[i]))
                    {
                        count++;
                    }
                    else
                    {
                        list.Add(word[i]);
                    }
                }*/
                //resultIndex.Add(count);
                //list.Clear();

                #endregion
            }

            if (equal.Equals(arr.Length))
                return "-1";
            var r =resultIndex.Where(x => x == resultIndex.Max()).First();

           return arr[resultIndex.IndexOf(resultIndex.Where(x=>x==resultIndex.Max()).First())];
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(LetterCount(Console.ReadLine()));
        }
    }
}