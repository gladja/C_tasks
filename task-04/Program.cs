using System;

namespace task_04
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int year = Convert.ToInt32(Console.ReadLine()) + 18;
            Console.WriteLine("{0} will reach adulthood in {1}", name, year);
            // Console.WriteLine(dateBirth);
        }
    }
}