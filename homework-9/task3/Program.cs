// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// Console.Clear();
// int Prompt(string message)
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int Akkerman(int m, int n)  

// {
//     if (m == 0) return n + 1;
//     if (m > 0 && n == 0) return Akkerman(m - 1, 1);
//     else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// int m = Prompt("Input M: ");
// int n = Prompt("Input N: ");

// int result = Akkerman(m, n);

// Console.WriteLine($"A({m},{n}) = {result}");


int Prompt(string message)
{
    Console.Write(message);
    int result;
    while (!int.TryParse(Console.ReadLine(), out result) || result < 0)
    {
        Console.WriteLine("Invalid input. Please enter a valid positive integer.");
        Console.Write(message);
    }
    return result;
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = Prompt("Input M: ");
int n = Prompt("Input N: ");

int result = Akkerman(m, n);

Console.WriteLine($"A({m},{n}) = {result}");