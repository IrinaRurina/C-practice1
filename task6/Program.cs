using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            int half1 = number / 2;
            double half2 = (double) number / 2;
            double difference = half2 - half1;

            if(difference == 0)
            {
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("Нечетное");
            }
        }
    }
}
