using System;

namespace task_01
{
    class Program
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int max = num;
            int min = 0;
            // int min2 = num;


            while (num != 0)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }

                if (num > max)
                {
                    max = num;
                }
                else
                {
                    min = num;
                }

                if (num > min)
                {
                    min = num;
                }




                // if (min == 0)
                // {
                //     min = max;
                // }


            }
            Console.WriteLine(min);

        }
    }
}





// if (num < max)
// {
//     min = num;
// }
// if (min < num)
// {
//     min = num;
// }
// if (min == 0)
// {
//     min = max;
// }




