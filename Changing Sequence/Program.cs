using System;

namespace Changing_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int ChangingSequence(int[] arr)
            {

                int result = -1;
                // code goes here  
                if (arr[0]<arr[1])
                {
                    for (int i = 0; i < arr.Length-1; i++)
                    {
                        if (arr[i]>arr[i+1])
                        {
                            result = i;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < arr.Length-1; i++)
                    {
                        if (arr[i]<arr[i+1])
                        {
                            result = i;
                            break;
                        }
                    }
                }
                
                
                return result;

            }
            
            Console.WriteLine(ChangingSequence(new int[] {-4, -2, 9, 10}));
            Console.WriteLine(ChangingSequence(new int[] {5, 4, 3, 2, 10, 11}));
            Console.WriteLine(ChangingSequence(new int[] {1, 2, 4, 6, 4, 3, 1}));
        }
    }
}