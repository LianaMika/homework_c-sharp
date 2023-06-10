﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        {
            array[i] = new Random().Next(0, 1001);
        }
    return array;
}

int GetLength()
{
    Console.WriteLine("Введите длину");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int count = 0;
for (int i = 0; i < length; i++) 
{
    if (array[i] >= 10 && array[i] <= 99)
    {
        count++;
    }

    return 0;
}

// int length = GetLength();
// int[] array = GetArray(length);
// string arrayToStr = String.Join(",", array);

Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10, 99] {count}");   