using System;

namespace _10sumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 0, 2,3, 4, 5, 6, 7, 9, 10 };
            

            foreach (int numbers in SumTargetArr(num,9))
            {
                Console.WriteLine(numbers);
            }
        }
        public static int [] SumTargetArr(int [] arr,int num)
        {
            int[] SumofTarget = new int[0];
            int f = 0;

            for (int i = 1; f < arr.Length - 1; i++)
            {
                if (i < arr.Length)
                {
                    if (arr[f] + arr[i] == num)
                    {
                        Array.Resize(ref SumofTarget, SumofTarget.Length + 1);
                        SumofTarget[SumofTarget.Length - 1] = arr[f];
                        Array.Resize(ref SumofTarget, SumofTarget.Length + 1);
                        SumofTarget[SumofTarget.Length - 1] = arr[i];
                    }
                }
                else
                {
                    i = f + 1;
                    f++;
                }
            }
            return SumofTarget;
        }
    }
}
