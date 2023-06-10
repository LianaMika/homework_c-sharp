// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

int GetLength()
{
    Console.WriteLine("Введите длину");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int SumPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int SumNegative(int[] array)
{
    int sum = 0;

    foreach (int number in array)
    {
        if (number < 0)
        {
            sum += number;
        }
    }

    return sum;
}

int length = GetLength();
int[] array = GetArray(length);
int sumPositive = SumPositive(array);
int sumNegative = SumNegative(array);
string arrayToStr = String.Join(",", array);


Console.WriteLine($"Сумма положительных {sumPositive}, сумма отрицательных {sumNegative}, массив: {arrayToStr}");
