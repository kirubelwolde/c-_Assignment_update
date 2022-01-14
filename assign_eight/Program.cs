using System;
namespace time_to_Degree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Houres ");

            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Minutes : ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            double hour_to_degree = (hours * 30) + (minutes * 30.0 / 60);
            double minute_to_degree = minutes * 6;

            double value = Math.Abs(hour_to_degree - minute_to_degree);

            if (value > 180)
            {
                value = 360 - value;
            }

            Console.WriteLine($"Angle between {hours} hour and {minutes} minute is {value} degrees");
            Console.ReadKey();
        }
    }
}