using System;

namespace task50
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

            int M = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            int [,] array = new int[M, N];

            Random rnd = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i,j] = rnd.Next(-10,  10);
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите i и j");
            int findI = Convert.ToInt32(Console.ReadLine());
            int findJ = Convert.ToInt32(Console.ReadLine());

            if (findI < M && findJ < N)
            {
                Console.WriteLine("Значение элемента: " + array[findI,findJ]);
            }
            else
            {
                Console.WriteLine("Такого элемента нет в заданном массиве");
            }
        }
    }
}
