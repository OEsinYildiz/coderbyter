using System;
using System.Collections.Generic;

namespace SukruS_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İterasyon değeri giriniz: ");

            int size = Convert.ToInt32(Console.ReadLine());

            //int[] exp2 = Producer.ArrayProcedure(-20, 20, size);
            //int[] exp1 = Producer.ArrayProcedure(-20, 20, size);
            //int[] exp1 = { 1,29,3, 8 };
            //int[] exp2 = { 7, 15 };
            List<int> exp1 = Producer.ArrayGenerator(new []{1,29, -900}, 30000);
            List<int> exp2 = Producer.ArrayGenerator(new []{7, 15, 1, 1, 90, 90}, 90000);
            exp1.Sort();
            exp2.Sort();
            //Array.Sort(exp2);
            double sayac = 0;
            int Length1 = exp1.Count;
            int Length2 = exp2.Count;
            for (int i = 0; i < Length1; i++)
            {
                for (int j = 0; j < Length2; j++)
                {
                    if (exp1[i] > exp2[j])
                    {
                        sayac++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            double result = (sayac / (Length1 * Length2));
            Console.WriteLine(result);
        }
    }

    static class Producer
    {
        internal static int[] ArrayProcedure(int Min, int Max, int size)
        {
            int[] arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(Min, Max);
            }

            return arr;
        }

        internal static List<int> ArrayGenerator(int[] arr, int size)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    list.Add(arr[j]);
                }
            }

            return list;
        }
    }
}