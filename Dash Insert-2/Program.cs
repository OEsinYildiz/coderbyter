using System;
using System.Collections.Generic;
using System.Linq;

namespace Dash_Insert_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string DashInsert(string str) {

                // code goes here  
                List<int> list = new List<int>();
                foreach (var item in str)
                {
                    list.Add(int.Parse(item.ToString()));
                }
                
                
                Stack<string> stack = new Stack<string>();

                for (int i = 0; i < list.Count-1; i++)
                {
                    if (list[i]%2==1 && list[i+1]%2==1)
                    {
                        stack.Push(list[i].ToString());
                        stack.Push("-");
                    }
                    else
                    {
                        stack.Push(list[i].ToString());
                    }
                }
                
                stack.Push(list.Last().ToString());
                
                string result = string.Concat(stack.Reverse()).TrimEnd('-');
                return result;

            }
            
            Console.WriteLine(DashInsert("99946"));
            Console.WriteLine(DashInsert("77993"));
            Console.WriteLine(DashInsert("2129"));
            Console.WriteLine(DashInsert("399047"));
            Console.WriteLine(DashInsert("60497"));
        }
    }
}