// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// class Program
// {
//     static int[] GetArray(int length)
//     {
//         int[] array = new int[length];
//         Random random = new Random();

//         for (int i = 0; i < length; i++)
//         {
//             array[i] = random.Next(0, 1000);
//         }

//         return array;
//     }

//     static int GetLength()
//     {
//         Console.WriteLine("Введите длину:");
//         int length = Convert.ToInt32(Console.ReadLine());
//         return length;
//     }

//     static int Count(int[] array)
//     {
//         int count = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i] >= 10 && array[i] <= 99)
//             {
//                 count++;
//             }
//         }

//         return count;
//     }

//     static void Main()
//     {
//         int length = GetLength();
//         int[] array = GetArray(length);
//         int count = Count(array);
//         string arrayToStr = string.Join(", ", array);

//         Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10, 99]: {count}");
//         // Console.WriteLine($"Массив: {arrayToStr}");
//     }
// }

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

int GetLength()
{
    Console.WriteLine("Введите длину");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }

    return count;
    
}

int length = GetLength();
int[] array = GetArray(length);
int count = Count(array);
string arrayToStr = String.Join(",", array);

Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10, 99]: {count}");