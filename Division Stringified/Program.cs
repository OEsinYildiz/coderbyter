using System;

namespace Division_Stringified
{
    class Program
    {
        static void Main(string[] args)
        {
            string DivisionStringified(int num1, int num2)
            {

                var result = Math.Round((double)num1 /(double) num2);
                // code goes here 
                if (result.ToString().Length > 3)
                {
                    return result.ToString().Insert(result.ToString().Length-3, ",");
                }
                return result.ToString();
            }

            Console.WriteLine(DivisionStringified(123456789, 10000));
            Console.WriteLine(DivisionStringified(63, 14));
            Console.WriteLine(DivisionStringified(2, 3));
            Console.WriteLine(DivisionStringified(1, 10));
        }
    }
}