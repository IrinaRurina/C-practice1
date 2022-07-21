using System;

namespace task60
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сформируйте трехмерный массив из неповторяющихся двузначных чисел
            // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

            int[,,] GetArrayUniqueNumbers (int m, int n, int o, int minRandom, int maxRandom)
            {
                int [,,] result = new int[m,n,o];
                int[] numbers = new int[m*n*o];

                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    numbers[i] = new Random().Next(minRandom, maxRandom + 1);
                    for (int j = 0; j < i; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            i--;
                        }
                    }
                }


                int index = 0;
                for (int i = 0; i < result.GetLength(0); i++) 
                {
                    for (int j = 0; j < result.GetLength(1); j++) 
                    {
                        for (int k = 0; k < result.GetLength(2); k++)
                        {
                            result[i,j,k] = numbers[index];
                            index++;                       
                        }
                    }
                }
                return result;
            }

            int[,,] array = GetArrayUniqueNumbers(2,2,2,10,99);


            void PrintArray(int[,,] inputArray)
            {
                for (int i = 0; i < inputArray.GetLength(0); i++)
                {
                    for (int j = 0; j < inputArray.GetLength(1); j++)
                    {
                        for (int k = 0; k < inputArray.GetLength(2); k++)
                        {
                            Console.WriteLine("{0} ({1}, {2}, {3})", inputArray[i,j,k], i, j, k);
                        }
                    }
                }
            }
            
            Console.WriteLine("Трехмерный массив:");
            PrintArray(array);
        }
    }
}
