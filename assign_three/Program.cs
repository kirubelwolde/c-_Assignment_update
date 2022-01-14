// See https://aka.ms/new-console-template for more information
using System;
namespace reverse_string
{

    class program

    {
        static void Main(String[] args)
        {

            string[] names = Console.ReadLine().Split(",");


            reveres(names);





        }
        static void reveres(string[] temp)
        {

            int len = temp.Length - 1;
            foreach (var item in temp)
            {
                System.Console.Write($"{temp[len]}\t");
                len -= 1;
            }
        }
    }
}
