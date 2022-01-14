using System;
namespace chcek_palindrom
{
    class progam
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            chcek_palindrom(word);


        }
        static void chcek_palindrom(string word)
        {
            int hold = word.Length - 1;
            string values = "";

            foreach (var x in word)
            {
                values += word[hold].ToString();
                hold -= 1;

            }

            if (values == word)
            {
                System.Console.WriteLine("Palindrom");
            }
            else
            {
                System.Console.WriteLine("Not palindrom");
            }

        }

    }
}