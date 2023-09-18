using System;

namespace Power_Set_Count
{
    class Program
    {
        public static int PowerSetCount(int[] arr)
        {
            // code goes here  

            int lenght = arr.Length;
            int result = 1;
            for (int i = 0; i <= lenght; i++)
            {
                result += CalculatePer(i, lenght);
            }
            
            return result;
        }

        private static int CalculatePer(int x, int len)
        {
            return Factorial(len) / (Factorial(x) * Factorial(len - x));
        }

        private static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }

            return x * Factorial(x - 1);
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(PowerSetCount(new int[] { 5, 6 }));
        }
    }
}