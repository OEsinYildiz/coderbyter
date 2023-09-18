using System;
using System.Globalization;

namespace Time_Calculator
{
    class Program
    {
        public static string StringChallenge(string str)
        {
            // code goes here  

            var arr = str.Split('-');
            var firstHour = DateTime.Parse(arr[0]).TimeOfDay;
            var secondHour = DateTime.Parse(arr[1]).TimeOfDay;
            //var firstMinutes = DateTime.Parse(arr[0]).Minute;
            //var secondMinutes = DateTime.Parse(arr[1]).Minute;
            string result = string.Empty;

            if (firstHour>secondHour)
            {
                var saat =24-(firstHour - secondHour).Hours;
                var dakika = (secondHour - firstHour).Minutes;
                result = ((saat * 60) + dakika).ToString();
            }
            else
            {
                var saat =(secondHour - firstHour).Hours;
                var dakika = (secondHour - firstHour).Minutes;
                result = ((saat * 60) + dakika).ToString();
            }
            
            
            
            /*if (arr[0].EndsWith("pm") && arr[1].EndsWith("am"))
                result = Math.Abs((24 - (secondHour - firstHour)) * 60 + Math.Abs(secondMinutes - firstMinutes))
                    .ToString();

            if (arr[0].EndsWith("am") && arr[1].EndsWith("am")&& secondHour<firstHour)
                result = Math.Abs((secondHour - firstHour) * 60 + Math.Abs(secondMinutes - firstMinutes)).ToString();
            
            if (arr[0].EndsWith("am") && arr[1].EndsWith("am"))
                result = Math.Abs((secondHour + firstHour) * 60 + Math.Abs(secondMinutes - firstMinutes)).ToString();*/

            return result;
        }

        static void Main()
        {
            // keep this function call here
            Console.WriteLine(StringChallenge(Console.ReadLine()));
        }
    }
}