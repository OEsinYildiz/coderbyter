using System;

namespace Prime_Time
{
    class Program
    {
        
        public static bool PrimeTime(int num) {

            // code goes here
            for (int i = 2; i < num/2; i++)
            {
                if(num==i)
                    break;
                if (num % i == 0)
                    return false;
            }
            return true;

        }
        
        static void Main(string[] args)
        {
            // keep this function call here
            Console.WriteLine(PrimeTime(Convert.ToInt32(Console.ReadLine())));
        }
    }
}