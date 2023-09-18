using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dash_Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            string DashInsert(int str)
            {
                string number = str.ToString();
                //StringBuilder stringBuilder = new StringBuilder();
                Stack<char> stack = new Stack<char>();

                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] % 2 == 1)
                    {
                        stack.Push(number[i]);
                        stack.Push('-');
                    }
                    else
                    {
                        if (stack.Count == 0)
                        {
                            stack.Push(number[i]);
                            continue;
                        }

                        if (number[i-1] % 2 == 0)
                        {
                            stack.Push(number[i]);
                            continue;
                        }
                        stack.Pop();
                        stack.Push(number[i]);
                    }
                }

                var result = String.Concat(stack.Reverse()).Trim('-');
                return result;
            }

            Console.WriteLine(DashInsert(454793));
            Console.WriteLine(DashInsert(99946));
            Console.WriteLine(DashInsert(56730));
        }
    }
}