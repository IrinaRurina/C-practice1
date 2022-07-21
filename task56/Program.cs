using System;

namespace task56
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

            Console.Write("Введите количество строк массива: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов массива: ");
            int columns = int.Parse(Console.ReadLine());

            if (rows == columns)
            {
                Console.WriteLine("Массив должен быть прямоугольным");
                return;
            }

            int[,] GetArray (int m, int n, int minRandom, int maxRandom)
            {
                int [,] result = new int[m,n];
                for (int i = 0; i < result.GetLength(0); i++) 
                {
                    for (int j = 0; j < result.GetLength(1); j++) 
                    {
                        result[i,j] = new Random().Next(minRandom, maxRandom + 1);
                    }
                }
                return result;
            }
            int[,] array = GetArray(rows,columns, 0, 10);

            void PrintArray(int[,] inputArray)
            {
                for (int i = 0; i < inputArray.GetLength(0); i++)
                {
                    for (int j = 0; j < inputArray.GetLength(1); j++)
                    {
                        Console.Write(inputArray[i,j] + "\t"); 
                    }
                    Console.Write("\n"); 
                }
            }
            PrintArray(array);

            int FindMinSumLine(int[,] inputArray)
            {
                int[] sum = new int[inputArray.GetLength(0)];
                int minSumLineIndex = 0;

                for (int i = 0; i < inputArray.GetLength(0); i++)
                {
                    for (int j = 0; j < inputArray.GetLength(1); j++)
                    {
                        sum[i] = sum[i] + inputArray[i,j];
                    }
                    if (sum[minSumLineIndex] > sum[i])
                    {
                        minSumLineIndex = i;
                    }
                }
                Console.Write("\n");
                Console.WriteLine("Строка с наименьшей суммой элементов: " + minSumLineIndex);
                return minSumLineIndex;
            }

            FindMinSumLine(array);

        }
    }
}
