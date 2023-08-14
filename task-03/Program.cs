using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {

            int num = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MinValue;
            int count = 0;

            while (num != 0)
            {
                if (num == 0)
                {
                    break;
                }

                if (num > max && num > min)
                {
                    min = max;
                    max = num;
                    count = 0;
                }
                else
                {
                    if (num == int.MinValue)
                    {
                        min = num;
                    }
                    else
                    {
                        if (num > min)
                        {
                            min = num;
                        }
                    }
                }

                // if (num < max)
                // {
                //     min = num;
                //     // count++;
                // }

                // if (num > min)
                // {
                //     min = num;
                // }
                num = Convert.ToInt32(Console.ReadLine());
            }
            // Console.WriteLine($"count:{count}");
            // Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}



