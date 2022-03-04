using System;

namespace Arr3DigitVSOtherDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 10, 20, 100, 200, 300 };
            //int[] digit = new int[0];
            //int[] otherdigit = new int[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]/100!=0)
            //    {
            //        Array.Resize(ref digit, digit.Length + 1);
            //        digit[digit.Length - 1] = arr[i];
            //    }
            //    else
            //    {

            //        Array.Resize(ref otherdigit, otherdigit.Length + 1);
            //        otherdigit[otherdigit.Length - 1] = arr[i];
            //    }
            //}
            //int result;
            //foreach (int num in digit)
            //{
            //    foreach (int number in otherdigit)
            //    { 
            //        result=num - number;
            //        Console.WriteLine($"{num}-{number}="+result);
            //    }
            //}

            int[] arr1 = { 11, 20, 103, 206, 307 };
            int[] digit1 = new int[0];
            int[] otherdigit1 = new int[0];
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    Array.Resize(ref digit1, digit1.Length + 1);
                    digit1[digit1.Length - 1] = arr1[i];
                }
                else
                {

                    Array.Resize(ref otherdigit1, otherdigit1.Length + 1);
                    otherdigit1[otherdigit1.Length - 1] = arr1[i];
                }
            }
            int result1;
            foreach (int num in digit1)
            {
                foreach (int number in otherdigit1)
                {
                    result1 = num - number;
                    Console.WriteLine($"{num}-{number}=" + result1);
                }
            }
        }
    }
}
