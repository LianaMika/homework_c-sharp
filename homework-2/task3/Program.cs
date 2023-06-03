// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine ("введите число");
int number = Convert.ToInt32(Console.ReadLine());
// Int1 = понедельник
// Int2 = вторник
// Int3 = среда
// Int4 = четверг
// Int5 = пятница
// Int6 = суббота
// Int7 = воскресенье

if (number == 6 || number == 7)
{
    Console.WriteLine ("Выходной день");
}
else if (number < 6 && number > 0)
{
    Console.WriteLine ("Не выходной день");
}
else if (number > 6 || number <= 0)
{
    Console.WriteLine ("Такого дня не существует");
}