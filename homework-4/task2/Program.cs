// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string mess)
{
    System.Console.Write(mess);
    string readInput = System.Console.ReadLine();
    int res = int.Parse(readInput);
    return res;
}

int SumAllDigit(int number)
{
    int res = 0;
    while (number > 0)
    {
        res += number %10;
        number = number / 10;
    }
    return res;
}

int number = Prompt("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");
