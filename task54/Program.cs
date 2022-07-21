using System;

namespace task54
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте двумерный массив.
            // Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

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

            void SortDownLinesInArray(int[,] inputArray)
            {
                for (int i = 0; i < inputArray.GetLength(0); i++) // выбор строки для сортировки
                {                   
                    for (int sortCycle = 0; sortCycle < inputArray.GetLength(1); sortCycle++) // перемещение максимального элемента в начало строки, сокращение строки на найденные максимумы
                    {
                        int maxValueJ = sortCycle;
                        int temp = 0;
                        for (int j = sortCycle; j < inputArray.GetLength(1); j++) // нахождение максимума в оставшейся строке, без учета ранее найденных максимумов
                        {
                            if (inputArray[i,j] > inputArray[i,maxValueJ])
                            { 
                                maxValueJ = j;
                            } 
                        }
                        temp = inputArray[i,sortCycle];
                        inputArray[i,sortCycle] = inputArray[i,maxValueJ];
                        inputArray[i,maxValueJ] = temp;
                        Console.Write(inputArray[i,sortCycle] + "\t");
                    }
                    Console.Write("\n");
                }
            }

            Console.WriteLine("Результат:");
            SortDownLinesInArray(array);

        }
    }
}
