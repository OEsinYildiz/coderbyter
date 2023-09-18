using System;
using System.Text.RegularExpressions;

class MainClass {

  public static string CodelandUsernameValidation(string str) {

    // code goes here  
    string pattern = @"^[a-zA-z]\w{2}|(\w{23})?(?!_)$";
    string patternTwo = @"^([a-zA-Z])([a-zA-Z0-9_]{2,23})([^_])$";
    Regex rg = new Regex(patternTwo);
    if (rg.IsMatch(str))
      return "true";
    else
      return "false";

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
  } 

}