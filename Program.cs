using System;

namespace programIntro
{
    class Program
    {
        static void Main(string[] args)
        {   //birOlculuArraydeEdedleriTersYazmaq
            //int[] numbers = { 1, 0,40, 5, 0 };

            //int j = numbers.Length-1;
            //int i = 0;
            //while (i <numbers.Length/2)
            //{
            //    int a = numbers[i];
            //    int b = numbers[j];
            //    numbers[j] = a;
            //    numbers[i] = b;
            //    j--;
            //    i++;

            //}
            //for (int h = 0; h < numbers.Length; h++)
            //{
            //    Console.WriteLine(numbers[h]);
            //}

            //ArraydekiUniqueReqemleriPrintEtmek

            int[] numbers = { 1, 5, 8, 5,8 };
            bool isUnique = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)

                {
                    if (j != i && numbers[j] == numbers[i])
                    {
                        isUnique = false;
                        break;
                        
                    }
                    else
                    {
                        isUnique = true;
                    }
                    
                }

                if (isUnique==true)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            
        }
    }
}

