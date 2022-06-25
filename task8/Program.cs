using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            int N = Convert.ToInt32(Console.ReadLine());
            int index = 2;
            Console.WriteLine("Все четные числа от 0 до N:");

            while(index <= N)
            {
                Console.WriteLine(index);
                index = index + 2;
            }
        }
    }
}
