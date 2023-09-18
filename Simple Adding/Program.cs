using System;

namespace Simple_Adding
{
    class Program
    {
        static void Main(string[] args)
        {
            int SimpleAdding(int num)
            {

                int sum = 0;
                for (int i = num; i > 0; i--)
                {
                    sum += i;
                }
                // code goes here  
                return sum;

            }

            Console.WriteLine(SimpleAdding(12));
            Console.WriteLine(SimpleAdding(140));
        }
    }
}