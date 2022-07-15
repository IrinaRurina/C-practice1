using System;

namespace task41
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

            Console.WriteLine("Введите несколько положительных и отрицательных чисел через пробел");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
         
            int positive = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) {positive += 1;}
            }
            Console.WriteLine("Количество положительных чисел - " + positive);
        }
    }
}
