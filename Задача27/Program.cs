//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int sumOfDigits = CalculateSumOfDigits(number);

        Console.WriteLine($"Сумма цифр числа равна: {sumOfDigits}");
    }

    // Функция для вычисления суммы цифр числа
    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }
        return sum;
    }
}
