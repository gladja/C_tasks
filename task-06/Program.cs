using System;

public class Test
{

    static int[,] InitByKeyBoardLine(int n)
    {
        int[,] arr = new int[n, n];
        int up = 0;
        int down = 0;
        int left = 0;
        int right = 0;

        int k = 1;
        int i = 0;
        int j = 0;

        while (k <= n * n)
        {
            arr[i, j] = k;

            if (i == up && j < n - right - 1)
            {
                j++;
            }
            else if (j == n - right - 1 && i < n - down - 1)
            {
                i++;
            }
            else if (i == n - down - 1 && j > left)
            {
                j--;
            }
            else
            {
                i--;
            }

            if ((i == up + 1) && (j == left) && (left != n - right - 1))
            {
                up++;
                down++;
                right++;
                left++;
            }
            k++;
        }
        return arr;
    }

    static void NewArr(int[,] arr)
    {

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)

    {
        int n = Convert.ToInt16(Console.ReadLine());
        NewArr(InitByKeyBoardLine(n));
    }
}

