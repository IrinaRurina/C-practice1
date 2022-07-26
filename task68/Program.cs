using System;

namespace task68
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

            int Akkerman(int m, int n)
            {
                if (m == 0) return n + 1;
                else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
                else return Akkerman(m - 1, Akkerman(m, n - 1));
            }
            Console.WriteLine(Akkerman(2,3));
            Console.WriteLine(Akkerman(3,10));
        }
    }
}
