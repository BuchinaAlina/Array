//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
//массив [10 21 14 93 23] => 2

using System;

class Program
{
    static void Main()
    {
        int[] array = new int[] { 10, 21, 14, 93, 23, 45, 70, 88, 99, 12 };
        int count = 0;

        foreach (int num in array)
        {
            if (num >= 20 && num <= 90)
            {
                count++;
            }
        }

        Console.WriteLine("Массив: [" + string.Join(" ", array) + "]");
        Console.WriteLine("Количество элементов в диапазоне [20, 90]: " + count);
    }
}
