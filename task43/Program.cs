using System;

namespace task43
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая найдет точку пересечения двух прямых y=k1*x+b1, y=k2*x+b2
            // Значения k1, b1, k2, b2 задаются пользователем

            void linearCross(int k1, int b1, int k2, int b2)
            {
                if (k1 == k2) 
                {
                    Console.WriteLine("Точки пересечения не существует - прямые параллельны");
                }

                else
                {
                    double x = (b2 - b1) / (k1 - k2);
                    double y = k1 * x + b1;

                    Console.WriteLine("Координаты точки пересечения прямой y = {0} * x + {1} и прямой y = {2} * x + {3} - ({4},{5})", k1, b1, k2, b2, x, y);
                }
            }
            linearCross(-2, -5, 3, 0);
            linearCross(1, 3, -2, 12);
            linearCross(2, 1, 2, 5);
        }
    }
}
