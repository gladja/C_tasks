using System;

namespace task_04
{
    class Program
    {
        static void Main()
        {
            string nameOne = Console.ReadLine();
            int yearOne = Convert.ToInt32(Console.ReadLine()) + 18;
            Console.WriteLine("{0} will reach adulthood in {1}", nameOne, yearOne);

            string nameTwo = Console.ReadLine();
            int yearTwo = Convert.ToInt32(Console.ReadLine()) + 18;
            Console.WriteLine("{0} will reach adulthood in {1}", nameTwo, yearTwo);

            string nameThree = Console.ReadLine();
            int yearThree = Convert.ToInt32(Console.ReadLine()) + 18;
            Console.WriteLine("{0} will reach adulthood in {1}", nameThree, yearThree);
        }
    }
}