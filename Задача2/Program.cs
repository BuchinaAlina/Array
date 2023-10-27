//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
//массив [6 7 19 34 3 1 4 7 9 1] => 3
//массив [1 8 43 4 55 60 3 2 1 3] => 4

using System;

class Program
{
    static void Main()
    {
        int[] array = GenerateRandomArray(10, 1...);
        int count = CountEvenNumbers(array);

        Console.WriteLine("Сгенерированный массив: [" + string.Join(" ", array) + "]");
        Console.WriteLine("Количество чётных чисел в массиве: " + count);
    }

    static int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] array = new int[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }

        return array;
    }

    static int CountEvenNumbers(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}
