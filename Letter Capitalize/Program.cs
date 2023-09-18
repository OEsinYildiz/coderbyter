using System;
using System.Linq;

namespace Letter_Capitalize
{
    class Program
    {
        static void Main(string[] args)
        {
            string LetterCapitalize(string str)
            {

                var arr = str.Split();
                return String.Join(' ', arr.Select(x =>
                {
                    return String.Concat(Char.ToUpper(x[0]), x.Substring(1));
                }));
            }

            Console.WriteLine(LetterCapitalize("hello world"));
        }
    }
}