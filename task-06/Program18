using System;

public class Test
{

    static int[,] InitByKeyBoardLine(int n, int m)
    {
        int[,] arr = new int[n, m];
        string[] str_arr;
        for (int i = 0; i < n; i++)
        {
            str_arr = (Console.ReadLine()).Split(' ');
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = Convert.ToInt32(str_arr[j]);
            }
        }
        return arr;
    }

    static void NewArr(int[,] arr, int n, int m)
    {
        for (int i = 0; i < m; i++)
        {
            int sum = 0;
            int sum2 = 0;
            for (int j = 0; j < n; j++)
            {
                if (arr[j, i] % 2 == 0)
                {
                    sum += arr[j, i];
                }
                if (arr[j, i] % 2 != 0)
                {
                    sum2 += arr[j, i];
                }
            }
            Console.Write($"{Math.Abs(sum - sum2)} ");

        }
    }

    static void Main(string[] args)

    {
        string[] data = Console.ReadLine().Trim().Split();
        int n = int.Parse(data[0]);
        int m = int.Parse(data[1]);

        NewArr(InitByKeyBoardLine(n, m), n, m);
    }

}