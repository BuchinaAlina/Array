//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите элементы массива (разделите числа запятыми): ");
        string input = Console.ReadLine();
        string[] inputElements = input.Split(',');

        int[] numbers = new int[inputElements.Length];

        for (int i = 0; i < inputElements.Length; i++)
        {
            numbers[i] = int.Parse(inputElements[i]);
        }

        Console.Write("Массив: [");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}

