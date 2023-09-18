using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Letter_Changes
{
    class Program
    {
        static void Main(string[] args)
        {
            string LetterChanges(string str)
            {
                var arr = str.Split(' ');
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var item in arr)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (Char.IsLetter(item[i]))
                        {
                            stringBuilder.Append((char)((int)item[i] + 1));
                        }
                        else
                        {
                            stringBuilder.Append(item[i]);
                        }
                    }
                    stringBuilder.Append(" ");
                }

                var result = stringBuilder.ToString().Trim(' ');
                var arrBig = new char[] { 'a', 'e', 'i', 'o', 'u' };
                for (int i = 0; i < arrBig.Length; i++)
                {
                    if (result.Contains(arrBig[i]))
                    {
                        result = result.Replace(arrBig[i], Char.ToUpper(arrBig[i]));
                    }
                }

                return result;
            }

            Console.WriteLine(LetterChanges("hello*3"));
            Console.WriteLine(LetterChanges("fun times!"));
        }
    }
}