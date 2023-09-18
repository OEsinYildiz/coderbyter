using System;

namespace Check_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            string CheckNums(int num1, int num2) {

               return num2 == num1 ?  "-1" : num2 > num1 ?  "true" : "false"; 
          

            }

            Console.WriteLine(CheckNums(3,122));
            Console.WriteLine(CheckNums(3, 3));
        }
    }
}