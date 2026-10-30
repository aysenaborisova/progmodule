/*
using System;

class Task1
{
    static void Main()
    {
        Console.Write("Введите N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите число: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Массив в обратном порядке:");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum = sum + arr[i];
        }
        double average = sum / n;

        int closest = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (Math.Abs(arr[i] - average) < Math.Abs(closest - average))
            {
                closest = arr[i];
            }
        }

        Console.WriteLine("Среднее арифметическое: " + average);
        Console.WriteLine("Ближайшее к среднему число: " + closest);
    }
}
*/
