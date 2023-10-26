//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
//массив [10 21 14 93 23] => 2


using System;

class Program
{
    static void Main()
    {
        int[] array = new int[10];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); // Генерируем случайное целое число от 1 до 100
        }

        Console.WriteLine("Сгенерированный массив: [" + string.Join(" ", array) + "]");
        
        int count = 0;
        foreach (int num in array)
        {
            if (num >= 20 && num <= 90)
            {
                count++;
            }
        }

        Console.WriteLine("Количество элементов в диапазоне [20, 90]: " + count);
    }
}
