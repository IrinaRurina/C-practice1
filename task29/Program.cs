using System;

namespace task29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задать и вывести на экран массив из N элементов

            int[] array(int N)
            {
                int [] result = new int[N];
                for(int i = 0; i <N; i++)
                {
                    result[i] = (new Random()).Next(0,100);
                    Console.Write(result[i] + " ");
                }
                Console.WriteLine();

                return result;
            }
            array(8);
        }
    }
}
