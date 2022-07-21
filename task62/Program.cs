using System;

namespace task62
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заполните спирально массив 4 на 4.

            int[,] spiralArray = new int[4,4];

            int index = 1;
            for (int j = 0; j < 4; j++)
            {
                spiralArray[0,j] = index;
                index++;
            }
            for (int i = 1; i < 4; i++)
            {
                spiralArray[i,3] = index;
                index++;
            }
            for (int j = 2; j >= 0; j--)
            {
                spiralArray[3,j] = index;
                index++;
            }
            for (int i = 2; i >= 1; i--)
            {
                spiralArray[i,0] = index;
                index++;
            }
            for (int j = 1; j < 3; j++)
            {
                spiralArray[1,j] = index;
                index++;
            }
            for (int j = 2; j >= 1; j--)
            {
                spiralArray[2,j] = index;
                index++;
            }
            Console.WriteLine("Спирально заполненный массив 4х4:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(spiralArray[i,j] + "\t");
                }
                Console.Write("\n");
            }

        }
    }
}
