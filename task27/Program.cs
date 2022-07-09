using System;

namespace task27
{
    class Program
    {
        static void Main(string[] args)
        {
            //вернуть сумму цифр в числе

            //int len = numLength(num);

            int digitSum(int num)
            {
                // ищу длину будущего массива
                int sum = 0;
                int length = 0;
                int countLength = 1;
                if(countLength > num)
                {
                    Console.WriteLine("Сумма равна 0");
                    return sum;
                }
                else
                {
                    while (countLength <= num)
                        {
                        countLength = countLength * 10;
                        length++;
                        }
                }
                // задаю и заполняю массив   

                int[] number = new int[length];
                int i = 0;
                int countNumber = num;
                    while(countNumber > 0)
                    {
                        int digit = countNumber % 10;
                        countNumber = (countNumber - digit) / 10;
                        number[length - 1 - i] = digit;
                        i ++;
                    }
                
                // Ищу сумму чисел
                for(int j = 0; j < length; j++)
                {
                    sum = sum + number[j];
                }
                
                Console.WriteLine("Сумма цифр числа " + num + " равна " + sum);
                return sum;
            }

            digitSum(0);
            digitSum(452);
            digitSum(82);
            digitSum(9012);
        }
    }
}
