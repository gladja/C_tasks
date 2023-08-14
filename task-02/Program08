using System;

namespace task_10
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            int a = num / 100;
            // Console.WriteLine(a);

            int b = (num / 10) % 10;
            // Console.WriteLine(b);

            int c = num % 10;
            // Console.WriteLine(c);

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            if (b > c)
            {
                b = b + c;
                c = b - c;
                b = b - c;
            }
            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }

            Console.WriteLine("{0}{1}{2}", c, b, a);


        }
    }
}
