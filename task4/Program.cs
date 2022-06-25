using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int numberB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int numberC = Convert.ToInt32(Console.ReadLine());
            
            if(numberA > numberB)
            {
                if(numberA > numberC)
                    Console.WriteLine(numberA);
                else
                    Console.WriteLine(numberC);    
            }
            else
            {
                if(numberB > numberC)
                    Console.WriteLine(numberB);
                else
                    Console.WriteLine(numberC);
            }        
        }
    }
}
