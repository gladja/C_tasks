using System;

namespace task_02
{
    class Program
    {
        static void Main()
        {
            string white = "";
            string black = "";

            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);

            string[] data2 = Console.ReadLine().Trim().Split();
            int c = int.Parse(data2[0]);
            int d = int.Parse(data2[1]);

            string[] data3 = Console.ReadLine().Trim().Split();
            int e = int.Parse(data3[0]);
            int f = int.Parse(data3[1]);

            string[] data4 = Console.ReadLine().Trim().Split();
            int g = int.Parse(data4[0]);
            int h = int.Parse(data4[1]);

            string[] data5 = Console.ReadLine().Trim().Split();
            int i = int.Parse(data5[0]);
            int j = int.Parse(data5[1]);

            string[] data6 = Console.ReadLine().Trim().Split();
            int k = int.Parse(data6[0]);
            int l = int.Parse(data6[1]);



            if ((a + b) % 2 == 0)
            {
                black = Convert.ToString(a) + " " + Convert.ToString(b);
            }
            else
            {
                white = Convert.ToString(a) + " " + Convert.ToString(b);
            }

            if ((c + d) % 2 == 0)
            {
                black = Convert.ToString(c) + " " + Convert.ToString(d);
            }
            else
            {
                white = Convert.ToString(c) + " " + Convert.ToString(d);
            }

            if ((e + f) % 2 == 0)
            {
                black = Convert.ToString(e) + " " + Convert.ToString(f);
            }
            else
            {
                white = Convert.ToString(e) + " " + Convert.ToString(f);
            }

            if ((g + h) % 2 == 0)
            {
                black = Convert.ToString(g) + " " + Convert.ToString(h);
            }
            else
            {
                white = Convert.ToString(g) + " " + Convert.ToString(h);
            }

            if ((i + j) % 2 == 0)
            {
                black = Convert.ToString(i) + " " + Convert.ToString(j);
            }
            else
            {
                white = Convert.ToString(i) + " " + Convert.ToString(j);
            }

            if ((k + l) % 2 == 0)
            {
                black = Convert.ToString(k) + " " + Convert.ToString(l);
            }
            else
            {
                white = Convert.ToString(k) + " " + Convert.ToString(l);
            }


            Console.WriteLine(white);
            Console.WriteLine(black);

        }
    }
}