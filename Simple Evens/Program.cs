using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Simple_Evens
{
    class Program
    {
        private static bool SimpleEvens(long num)
        {
            bool result = true;
            var arr = num.ToString().ToList();
            foreach (var item in arr)
            {
                if (Convert.ToInt32(item)%2!=0)
                {
                    result = false;
                    break;
                }
            }

            return result;
            int length = num.ToString().Length;
            string pattern = $@"[02468]{length}";
            //var response = Regex.Match(num.ToString(), pattern);
            var response = Regex.IsMatch(num.ToString(), pattern);
            return response;
        }

        static void Main()
        {
            Console.WriteLine(SimpleEvens(Convert.ToInt64(Console.ReadLine())));
        }
    }
}