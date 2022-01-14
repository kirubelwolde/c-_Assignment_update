// See https://aka.ms/new-console-template for more information
using System;
namespace find_all_substing
{
    class program
    {
        static void Main(string[] args)
        {
            string words = "abcde";
            for (int i = 1; i < words.Length; i++)
            {
                for (int j = 0; j <= words.Length - i; j++)
                {
                    string value = words.Substring(j, i);
                    Console.WriteLine(value);
                }
            }
        }
    }
}
