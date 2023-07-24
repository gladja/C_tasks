using System;

namespace task_03
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 12 || num >= 1 && num <= 2)
            {
                Console.WriteLine("Winter");
            }
            else if (num >= 3 && num <= 5)
            {
                Console.WriteLine("Spring");
            }
            else if (num >= 6 && num <= 8)
            {
                Console.WriteLine("Summer");
            }
            else if (num >= 9 && num <= 11)
            {
                Console.WriteLine("Autumn");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}