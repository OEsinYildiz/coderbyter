using System;
using System.Globalization;

namespace Counting_Minutes
{
    class Program
    {
        //12:30pm-12:00am
        // 12:30pm-02:45pm
        // 1:23am-1:08am
        // 2:23am-1:08am

        private static double CountingMinutes(string str)
        {
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
            var h = 60 * time.Hours;
            var m = time.Minutes;
            //var minutes = secondDate.Subtract(firstDate).Minutes;
            return Math.Abs(60*time.Hours)+time.Minutes;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CountingMinutes(Console.ReadLine()));
        }
    }
}