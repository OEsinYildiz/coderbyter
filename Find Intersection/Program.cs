using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {

    public static string FindIntersection(string[] strArr) {

        // code goes here  
        var firstSection = strArr[0].Split(",");
        var secondSection = strArr[1].Split(",");
        for (int i = 0; i < firstSection.Length; i++)
        {
            firstSection[i] = firstSection[i].Trim(' ');
        }
        
        for (int i = 0; i < secondSection.Length; i++)
        {
            secondSection[i] = secondSection[i].Trim(' ');
        }
        // Burdaki vurucu metot intersect metodu.
       var result= firstSection.Intersect(secondSection);
       
        /*for (int i = 0; i < firstSection.Length; i++)
        {
            list[Int32.Parse(firstSection[i].Trim())] = firstSection[i].Trim();
        }

        for (int i = 0; i < secondSection.Count(); i++)
        {
            if (list.ContainsValue(secondSection[i].Trim()))
            {
                result.Add(secondSection[i].Trim());
            }
        }*/

        return string.Join(",",result);
    }

    static void Main() {  
        // keep this function call here
        Console.WriteLine(FindIntersection( new string[] {"1, 2, 3, 4, 5", "6, 7, 8, 9, 10"}));
    } 

}