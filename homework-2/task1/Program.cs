// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine ("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99)
{
    number = number / 10;
    number = number % 10;
    Console.WriteLine ("Среднее число от введенного " + number);
}
else
{
    Console.WriteLine ("Введите трехзначное число!");
}