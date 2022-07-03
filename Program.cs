using System;

namespace dArrayReverse
{
    class reverse1DArray
    {
        static void Main(string[] arg)
        {
            int[] numbers = { 7, 5,7, 10, 52 };
            int a = 0;
            int b = 0;
            for (int i = 0, j=numbers.Length - 1; i < numbers.Length/2 && j>0; i++,j--)
            {

                a = numbers[i];
                b = numbers[j];
                numbers[i] = b;
                numbers[j] = a;
                
            }
            for (int d = 0; d < numbers.Length; d++)
            {
                Console.WriteLine(numbers[d]);
            }
           
        }
    }
}