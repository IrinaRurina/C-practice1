using System;

namespace task34
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте массив заполненный случайными положительными трёхзначными числами.
            // Напишите программу, которая покажет количество чётных чисел в массиве.

            int length = 4;
            int[] array = new int[length];
            Random rnd = new Random();
            int num = 0;

            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(100, 999);
                Console.Write(array[i] + " ");

                if (array[i] % 2 == 0)
                {
                    num++;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Количество четных чисел: " + num);
        }
    }
}
