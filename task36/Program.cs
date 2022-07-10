using System;

namespace task36
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            
            int length = 4;
            int[] array = new int[length];
            Random rnd = new Random();
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                Console.Write(array[i] + " ");                
            }

            for (int i = 1; i < length; i+=2)
            {
                sum = sum +array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);
        }
    }
}
