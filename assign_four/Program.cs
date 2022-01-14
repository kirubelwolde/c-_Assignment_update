using System;
namespace occurence
{


    public class program
    {
        public static void Main()
        {
            string str = "check occurence";
            Console.WriteLine("String: " + str);
            while (str.Length > 0)
            {
                Console.Write(str[0] + "= ");
                int hold = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        hold++;
                    }
                }
                Console.Write($"{hold} \t");
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}