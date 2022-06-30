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
            
            /*if(numberA > numberB)
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
            */
            int max = numberA;
            
            if (max < numberB)
            {
                max = numberB;
            }
            if (max < numberC)
            {
                max = numberC;
            }

            Console.WriteLine("Максимальным из трех чисел (" + numberA +", " + numberB + ", " + numberC + ") является число " + max + ".");
        
        }
    }
}
