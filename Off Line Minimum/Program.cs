using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Off_Line_Minimum
{
    class Program
    {
        static void Main(string[] args)
        {
            string OffLineMinimum(string[] strArr)
            {

                List<string> ls = strArr.ToList();
                
                List<int> result = new List<int>();
                List<int> list = new List<int>();

                for (int i = 0; i < ls.Count; i++)
                {
                    if (strArr[i] != "E")
                    {
                        list.Add((Convert.ToInt32(strArr[i])));
                    }
                    if (ls[i]== "E")
                    {
                        int min = list.Min();

                        result.Add(min);
                        list.Remove(min);
                    }
                }
                 
                // code goes here  
                return string.Join(',', result);

            }
            
            Console.WriteLine(OffLineMinimum(new[] {"1","2","E","E","3"}));
            Console.WriteLine(OffLineMinimum(new string[] {"4","E","1","E","2","E","3","E"}));
        }
    }
}