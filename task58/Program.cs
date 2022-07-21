using System;

namespace task58
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

            Console.Write("Введите количество строк массива: ");
            int rows = int.Parse(Console.ReadLine()); 

            Console.Write("Введите количество столбцов массива: ");
            int columns = int.Parse(Console.ReadLine());


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
            int[,] arrayA = GetArray(rows,columns, 0, 10);
            int[,] arrayB = GetArray(rows,columns, 0, 10);

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
            Console.WriteLine("Матрица A:");
            PrintArray(arrayA);
            Console.WriteLine("Матрица B:");
            PrintArray(arrayB);

            void multiplyTwoArrays(int m, int n, int[,] inputArrayA, int[,] inputArrayB) 
            {
                int[,] outputArray = new int[m,n];
                for (int i = 0; i < outputArray.GetLength(0); i++)
                {
                    for (int j = 0; j < outputArray.GetLength(1); j++)
                    {
                        outputArray[i,j] = inputArrayA[i,j] * inputArrayB[i,j];
                        Console.Write(outputArray[i,j] + "\t");
                    }
                    Console.Write("\n"); 
                }
            }
            Console.WriteLine("Результат умножения двух матриц:");
            multiplyTwoArrays(rows, columns, arrayA, arrayB);
        }
    }
}
