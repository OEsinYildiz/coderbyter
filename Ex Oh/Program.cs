using System;
using System.Linq;

namespace Ex_Oh
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ExOh(string str) {

                // code goes here

                int x = str.Count(x => x.Equals('x'));
                int o = str.Count(x => x.Equals('o'));
                
                return x==o;

            }
            
            Console.WriteLine(ExOh("xooxxo"));
            Console.WriteLine(ExOh("xooxxxxooxo"));
        }
    }
}