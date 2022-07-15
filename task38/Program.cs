using System;

namespace task38
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

            int length = 5;
            double[] array = new double[length];
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                Console.Write(array[i] + " ");                
            }
            double max = array[0];
            double min = array[0];

            for (int i = 1; i < length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("MAX - MIN = " + (max - min));
        }
    }
}
