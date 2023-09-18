using System;
using System.Text;

namespace Time_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string TimeConvert(int num)
            {
                StringBuilder stringBuilder = new StringBuilder();
                int hour = num / 60;
                int minute = num % 60;

                stringBuilder.Append(hour);
                stringBuilder.Append(":");
                stringBuilder.Append(minute);
                // code goes here  
                return stringBuilder.ToString();
            }

            Console.WriteLine(TimeConvert(126));
            Console.WriteLine(TimeConvert(45));
        }
    }
}