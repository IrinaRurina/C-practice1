using System;

namespace task52
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

            int M = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            int [,] array = new int[M, N];

            Random rnd = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i,j] = rnd.Next(0,  10);
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

            double[] average = new double [N];
            Console.WriteLine ("Среднее арифметическое по каждому столбцу:");

            for (int j = 0; j < N; j ++)
            {
                double sum = 0;
                for (int i = 0; i < M; i++)
                {
                    sum += array[i,j];
                }
                average[j] = sum / M;
                Console.Write(average[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
