using System;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чило от 1 до 7");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 1 | num > 7) {
                Console.WriteLine("Такого дня недели нет");
            }
            else {
                string[] weekDays = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
                Console.Write(weekDays[num - 1]);
                if (num < 6) {
                    Console.WriteLine(" - рабочий день.");
                }
                else {
                    Console.WriteLine(" - выходной день.");
                }
            }
        }
    }
}
