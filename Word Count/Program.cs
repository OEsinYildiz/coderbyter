 using System;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int WordCount(string str)
            {

                var arr = str.Split(' ');
                return arr.Length;
               

            }
            
            Console.WriteLine(WordCount("Never eat shredded wheat or cake"));
        }
    }
}