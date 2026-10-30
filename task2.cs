/*
using System;

class Task2
{
    static void Main()
    {
        Console.Write("Введите количество студентов: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество предметов: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] grades = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Студент " + (i + 1) + ", предмет " + (j + 1) + ": ");
                grades[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < n; i++)
        {
            double sum = 0;
            for (int j = 0; j < m; j++)
            {
                sum = sum + grades[i, j];
            }
            double average = sum / m;
            Console.WriteLine("Среднее значение студента " + (i + 1) + ": " + average);
        }
    }
}
*/
