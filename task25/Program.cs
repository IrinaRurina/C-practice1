using System;

namespace task25
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Написать цикл, который возвращает А в натуральной степени В

            int exponent(int A, int B)
            {
                int result = A;
                if (B <= 0)
                {
                    result = 0;
                    Console.WriteLine("Ошибка. Число B ("+ B + ") должно быть натуральным");
                    return result;
                }
                else
                {      
                    for(int i = 2; i <= B; i++)
                    {
                        result = result * A;
                    }
                    Console.WriteLine("{0} ^ {1} = {2}", A, B, result);
                    return result;
                }
            }

            exponent(2,4);
            exponent(-2,3);
            exponent(4,0);
            exponent(3,-2);

            
        }
    }
}
