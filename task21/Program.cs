using System;

namespace task21
{
    class Program
    {
        static void Main(string[] args)
        {
            double vectorAB(double xA, double yA, double zA, double xB, double yB, double zB)
            {
                double result = 0;
                if(xA == xB && yA == yB && zA == zB)
                {
                    return result;
                }
                result = Math.Sqrt(Math.Pow(xB - xA,2) + Math.Pow(yB - yA,2) + Math.Pow(zB - zA,2));
                return result;           
            }
            double AB1 = vectorAB(3, 6, 8, 2, 1, -7);
            Console.WriteLine(AB1);
            double AB2 = vectorAB(7, -5, 0, 1, -1, 9);
            Console.WriteLine(AB2);
            double zero = vectorAB(5, 6, 1, 5, 6, 1);
            Console.WriteLine(zero);
        }
    }
}
