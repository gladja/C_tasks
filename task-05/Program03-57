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

        static int[] CountOfDifferent(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if ((Math.Abs(arr[j + 1]) < Math.Abs(arr[j])) || (Math.Abs(arr[j]) == Math.Abs(arr[j + 1]) && (arr[j] > arr[j + 1])))
                    {
                        int t = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            return arr;
        }

        static void Created(int[] arr)
        {
            // for (int i = 0; i < arr.Length - 1; i++)
            // {
            //     if (Math.Abs(arr[i]) == Math.Abs(arr[i + 1]) && (arr[i] > arr[i + 1]))
            //     {
            //         int t = arr[i + 1];
            //         arr[i + 1] = arr[i];
            //         arr[i] = t;
            //     }
            // }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());

            Created(CountOfDifferent(myArr));
        }
    }
}