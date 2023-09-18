using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Couples
{
    public class Program
    {
        //array icerisinden ardisik iki eleman al. tersi array icerisinde var mi bak
        public static string ArrayCouples(int[] arr)
        {
            // code goes here  
            List<int> newList = arr.ToList();
            List<int> list = new List<int>();

            if (CheckElement(list, newList))
            {
                return "yes";
            }
            else
            {
                return string.Join(',', newList);
            }
        }

        private static bool CheckElement(List<int> list, List<int> newList)
        {
            bool result = false;
            list.Add(newList[0]);
            list.Add(newList[1]);
            list.Reverse();
            for (int i = 0; i < newList.Count - 1; i++)
            {
                if (newList[i].Equals(list[0]) && newList[i + 1].Equals(list[1]))
                {
                    newList.RemoveAll(x => list.Contains(x));
                    list.Clear();
                    break;
                }
            }

            if (newList.Count == 2)
            {
                result = false;
            }

            if (newList.Count > 2)
            {
                CheckElement(list, newList);
            }

            if (newList.Count == 0)
            {
                result = true;
            }

            return result;
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(ArrayCouples(new int[] { 4, 5, 1, 4, 5, 4, 4, 1 }));
        }
    }
}