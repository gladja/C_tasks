using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            string[] x = Console.ReadLine().Split('.');
            int uah = int.Parse(x[0]);
            int kop = int.Parse(x[1]);

            int sum = ((uah * 100) + (kop * 10)) / 10;
            int UAH, KOP, SUM;

            for (int i = 1; i <= 15; i++)
            {
                if (i < 10)
                {
                    SUM = sum * i;
                    UAH = SUM / 100;
                    KOP = SUM - (UAH * 100);
                    Console.WriteLine($" {i * 100} grams: {UAH} UAH {KOP} kop");
                }
                else
                {
                    SUM = sum * i;
                    UAH = SUM / 100;
                    KOP = SUM - (UAH * 100);
                    Console.WriteLine($"{i * 100} grams: {UAH} UAH {KOP} kop");
                }

            }
        }
    }
}

