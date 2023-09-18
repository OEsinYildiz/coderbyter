using System;
using System.Collections.Generic;
using System.Linq;

namespace Questions_Marks
{
    class Program
    {
        public static bool QuestionsMarks(string str)
        {
            // code goes here  
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    
                    int sum = 10 - Convert.ToInt32(str[i].ToString());
                    if (str.Contains(sum.ToString()))
                    {
                        string control = str.Substring(str.IndexOf(str[i])+1,
                            str.IndexOf(sum.ToString()) - str.IndexOf(str[i])-1);
                        if (control.Where(x => x.Equals('?')).Count() == 3)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(QuestionsMarks(Console.ReadLine()));
        }
    }
}