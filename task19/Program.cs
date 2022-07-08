using System;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*void isPalindrome(int num)
            {
                if(num / 10000 >=10 || num / 10000 < 1)
                {
                    Console.WriteLine("Данное число не пятизначное");
                }
                else
                {
                    int num1 = num / 10000;
                    int num2 = (num / 1000) % 10;
                    int num4 = (num % 100) / 10;
                    int num5 = num % 10;

                    if (num1 == num5 && num2 == num4) 
                    {
                        Console.WriteLine(num + " - это палиндром");
                    }
                    else
                    {
                        Console.WriteLine(num + " - это не палиндром");
                    }
                }
                
            }
            isPalindrome(14212);
            isPalindrome(23432);
            isPalindrome(12821);
            isPalindrome(2343);
            isPalindrome(128251);
            */

            bool isPalindrome(int[] arr)
            {
                bool result = false;
                int N = arr.Length;
                for (int i = 0; i < N/2; i++) 
                {
                    if (arr[i] != arr[N - i - 1])
                    {
                        Console.WriteLine("Not palindrome");
                        return result;
                    }
                } 
                result = true;
                Console.WriteLine("Palindrome");

                return result;
            }
            
            int[] arr = Array.ConvertAll(Console.Readline().Split(''), int.Parse); // ОШИБКА! Пустая символьная константа
            isPalindrome(arr);
        }
    }
}
