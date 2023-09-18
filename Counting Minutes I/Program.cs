using System;
using System.Globalization;

namespace Counting_Minutes_I
{
    class Program
    {
        static void Main(string[] args)
        {
            double CountingMinutesI(string str) {

                var arr = str.Split('-');
            
                DateTime firstDate = DateTime.Parse(arr[0], CultureInfo.CreateSpecificCulture("tr-TR"));
                DateTime secondDate = DateTime.Parse(arr[1], CultureInfo.CreateSpecificCulture("tr-TR"));
                var time = secondDate.Subtract(firstDate);
                if (time.Hours<0 || time.Minutes<0)
                {
                    return 1440-Math.Abs(60*time.Hours+time.Minutes);
                }
                else
                {
                    return Math.Abs(60*time.Hours)+time.Minutes;
                }

            }

            Console.WriteLine(CountingMinutesI("12:30pm-12:00am"));
        }
    }
}