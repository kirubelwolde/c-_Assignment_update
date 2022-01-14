// See https://aka.ms/new-console-template for more information
using System;
namespace second_largest
{
    class program
    {
        static void Main(string[] args)
        {
            int[] numbers = {
                  12,20,30,40,38
            };
            second_largest_number(numbers);

        }
        static void second_largest_number(int[] temp)
        {
            int largest_num = 0;
            int second_larges = 0;

            for (int i = 0; i < temp.Length; i++)
            {



                if (temp[i] > largest_num)
                {
                    second_larges = largest_num;
                    largest_num = temp[i];
                }
                else if (temp[i] > second_larges)
                {
                    second_larges = temp[i];
                }

            }
            System.Console.WriteLine(second_larges);

        }
    }
}