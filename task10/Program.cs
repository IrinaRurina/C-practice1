using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
        void secondOutOfThree(int threeDigits) {
            int second = (threeDigits % 100) / 10;
            Console.WriteLine("Вторая цифра числа " + threeDigits + " это " + second);
        }
        secondOutOfThree(456);
        secondOutOfThree(782);
        secondOutOfThree(918);
        }
    }
}
