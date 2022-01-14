using System;
namespace person
{
    class program
    {
        static void Main(string[] args)
        {
            String word = Console.ReadLine();
            rever_string(word);

        }
        static string rever_string(string word)
        {
            int hold = word.Length - 1;
            foreach (var x in word)
            {
                Console.Write(word[hold]);
                hold -= 1;
            }
            return "";
        }
    }
}
