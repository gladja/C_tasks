using System;

namespace Hello
{
    class Program
    {

        static int[] InitByKeyBoard(string str)
        {
            string[] date = str.Trim().Split();
            int[] arr = new int[date.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(date[i]);
            }
            return arr;
        }

        static void SumMin(int[] arr)
        {
            int min = int.MaxValue;
            int firstMin = arr[0]; ;
            int value = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string res = Math.Abs(arr[i]).ToString();
                for (int j = 0; j < res.Length; j++)
                {
                    int b = int.Parse($"{res[j]}");
                    value += b;
                }
                if (value < min)
                {
                    min = value;
                    count = i;
                }
                if (value == min)
                {
                    min = value;
                    // Console.WriteLine(min);
                    if (firstMin > arr[i])
                    {
                        firstMin = arr[i];
                        count = i;
                    }
                }
                value = 0;
            }
            Console.WriteLine(arr[count]);
            // Console.WriteLine(min);
            // Console.WriteLine(max);
            // return max;
        }

        static void SumMax(int[] arr)
        {
            int max = int.MinValue;
            int firstMax = arr[0]; ;
            int value = 0;


            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                string res = Math.Abs(arr[i]).ToString();
                for (int j = 0; j < res.Length; j++)
                {
                    int b = int.Parse($"{res[j]}");
                    value += b;
                }
                if (value > max)
                {
                    max = value;
                    count = i;
                }
                if (value == max)
                {
                    max = value;
                    if (firstMax < arr[i])
                    {
                        firstMax = arr[i];
                        count = i;
                    }
                }
                value = 0;
            }
            Console.WriteLine(arr[count]);
        }


        static void Main(string[] args)

        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());

            SumMin(myArr);
            SumMax(myArr);
        }
    }
}

