using System;
using System.Linq;
using Microsoft.VisualBasic;

namespace Third_Greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            string ThirdGreatest(string[] strArr) {

                // code goes here  
                strArr=strArr.OrderByDescending(x => x.Length).ToArray();

                return strArr[2];

            }
            
            Console.WriteLine(ThirdGreatest(new string[] {"coder","byte","code"}));
            Console.WriteLine(ThirdGreatest(new string[] {"abc","defg","z","hijk"}));
            Console.WriteLine(ThirdGreatest(new string[] {"hello", "world", "after", "all"}));
            Console.WriteLine(ThirdGreatest(new string[] {"hello", "world", "before", "all"}));
        }
    }
}