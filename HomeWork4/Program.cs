﻿// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.


// Задача 4: Вывод цифр числа через запятую

using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N < 10)
        {
            Console.WriteLine(N);
        }
        else
        {
            while (N > 0)
            {
                int currentDigit = N % 10;
                N /= 10;
                if (N > 0)
                {
                    Console.Write(currentDigit + ", ");
                }
                else
                {
                    Console.WriteLine(currentDigit);
                }
            }
        }
    }
}
