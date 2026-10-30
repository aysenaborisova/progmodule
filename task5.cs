/*
using System;

class Task5
{
    static void Main()
    {
        Console.WriteLine("Введите 9 чисел через пробел:");
        string[] parts = Console.ReadLine().Split(' ');

        int[,] first = new int[3, 3];
        int[,] second = new int[3, 3];

        int k = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                first[i, j] = Convert.ToInt32(parts[k]);
                k++;
            }
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                second[j, i] = first[i, j];
            }
        }

        Console.WriteLine("Было:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(first[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Стало:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(second[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
*/
