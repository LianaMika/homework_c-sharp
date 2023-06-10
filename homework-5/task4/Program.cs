// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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