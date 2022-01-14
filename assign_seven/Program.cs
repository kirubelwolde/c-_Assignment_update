using System;
namespace two_dimension_two_one
{
    class program
    {
        static void Main(string[] args)
        {
            int[,] hold = {
                {12,13,15},
                {10,20,30},
                {40,50,90}
            };
            foreach (var item in hold)
            {
                System.Console.Write($"{item} \t");
            }
        }
    }
}