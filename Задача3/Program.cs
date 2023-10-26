//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
//массив [2.2 0.4 9.11 7.2 78.98] => 78.58
//массив [1.22 4.5 3.33] => 3.28
using System;

class Program
{
    static void Main()
    {
        double[] array = GenerateRandomArray(10, 1.0, 100.0);
        double min = array[0];
        double max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }

            if (array[i] > max)
            {
                max = array[i];
            }
        }

        Console.WriteLine("Сгенерированный массив: [" + string.Join(" ", array) + "]");
        Console.WriteLine("Минимальный элемент: " + min);
        Console.WriteLine("Максимальный элемент: " + max);
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + (max - min));
    }

    static double[] GenerateRandomArray(int length, double minValue, double maxValue)
    {
        double[] array = new double[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            double randomValue = minValue + random.NextDouble() * (maxValue - minValue);
            array[i] = Math.Round(randomValue, 2); // Округляем до двух знаков после запятой
        }

        return array;
    }
}
