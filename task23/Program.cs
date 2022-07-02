using System;

namespace task23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] calculateCubes(int num)
            {
                int[] cubes = new int[num];
                int i = 1;
                while (i <= num)
                {
                    cubes[i-1] = i * i * i;  
                    Console.WriteLine(cubes[i-1]);   
                    i++;
                }    
                return cubes;              
            }
            
            int[] result1 = calculateCubes(3); 
            int[] result2 = calculateCubes(5);

        }
    }
}
