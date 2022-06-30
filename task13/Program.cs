using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");
            int num = Convert.ToInt32(Console.ReadLine());
            int len = numLength(num);

            int numLength(int num) {
                int length = 0;
                int countLength = num;
                while (countLength > 0) {
                    countLength = countLength / 10;
                    length++;
                }
                return length;
            }
            
            void fillArray(int[] array) {
                int index = 0;
                int countNumber = num;
                while(countNumber > 0) {
                    int digit = countNumber % 10;
                    countNumber = (countNumber - digit) / 10;
                    array[index] = digit;
                    index ++;
                }
            }

            /*void PrintArray(int[] col) {
                int count = col.Length;
                int position = 0;
                while(position < count)
                {
                    Console.WriteLine(col[position]);
                    position ++;
                }
            }*/

            if (len < 3) {
                Console.WriteLine("Третьей цифры нет");
            }
            else {
                int[] number = new int[len];
                fillArray(number);
                int thirdNumber = number[len-3];
                //PrintArray(number);
                Console.WriteLine("Третья цифра числа " + num + " - это " + thirdNumber);
            }

        }
    }
}
