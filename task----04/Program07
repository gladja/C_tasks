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

        static void CountOfDifferent(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            int indexMax = 0;
            int indexMin = 0;
            int value = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                value += arr[i];
                if (indexMax == 0 && indexMin == 0)
                {
                    indexMax = 1;
                    indexMin = 1;
                }
                if (max <= arr[i])
                {
                    max = arr[i];
                    indexMax = i + 1;
                }

                if (min > arr[i])
                {
                    min = arr[i];
                    indexMin = i + 1;
                }
            }

            Console.WriteLine(value);
            Console.WriteLine($"{max} {indexMax}");
            Console.WriteLine($"{min} {indexMin}");

        }

        static void Main(string[] args)

        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());

            CountOfDifferent(myArr);
        }
    }
}

