﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine ("введите первое число");
// string input1 = Console.ReadLine();
// int number1 = Convert.ToInt32(input1);
// Console.WriteLine ("введите второе число");
// string input2 = Console.ReadLine();
// int number2 = Convert.ToInt32(input2);
// int Max = number1;
// if (Max>number2)
// {
//     Console.WriteLine ("Максимальное число {0}",number1);
// }
// else 
// Console.WriteLine ("Максимальное число {0}",number2);



Console.WriteLine ("введите первое число");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);
Console.WriteLine ("введите второе число");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);
int max = number1;
int min = number2;
if (max < number2)
{
    max = number2;
    min = number1;
}
Console.WriteLine ("Большее число " + max);
Console.WriteLine ("Меньшее число " + min);
