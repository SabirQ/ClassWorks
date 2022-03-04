using System;

namespace _2arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 100, 201, 300,450 };
            int[] arr2 = { 1, 3, 100, 200, 300,320,340};
            int[] digit = new int[0];
            int counter = 0;
            foreach (var item in arr)
            {
                foreach (var item2 in arr2)
                {
                    if (item==item2)
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    Array.Resize(ref digit, digit.Length + 1);
                    digit[digit.Length - 1] = item;
                    counter = 0;
                }
                else
                {
                    counter = 0;
                }
            }
            foreach (var item in digit)
            {
                Console.WriteLine(item);
            }
        }
        //Array.Resize(ref digit, digit.Length + 1);
        //            digit[digit.Length - 1] = arr[i];
    }
}
