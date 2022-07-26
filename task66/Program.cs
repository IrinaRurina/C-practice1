using System;

namespace task66
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

            Console.Write("Введите M: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int SumNumbers(int start, int end)
            {
                if (start == end) return start;
                return (start + SumNumbers(start+1,end));
            }
            Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна {SumNumbers(M,N)}");
        }
    }
}
