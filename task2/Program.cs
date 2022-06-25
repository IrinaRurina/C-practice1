using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int numberB = Convert.ToInt32(Console.ReadLine());
            
            if(numberA > numberB){
                int max = numberA;
                int min = numberB;
                Console.WriteLine("MAX = {0}, MIN = {1}", max, min);
            }
            else{
                int max = numberB;
                int min = numberA;
                Console.WriteLine("MAX = {0}, MIN = {1}", max, min);
            }
        }
    }
}
