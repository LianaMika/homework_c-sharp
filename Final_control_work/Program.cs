﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []"


using System.Net;

int lenght = LenghtOfArray();
string[] myarr = UrArray(lenght);
Console.WriteLine();
PrintArray(myarr);
Console.WriteLine();
Console.WriteLine();
Test(myarr);
Console.WriteLine();
int newLenght = HowMany(myarr);
Console.WriteLine();
string[] newArray = ReadyArray(newLenght, myarr);
Console.WriteLine();
PrintArray(newArray);


int LenghtOfArray ()
{
Console.WriteLine ("Введите длину массива");
int l = Convert.ToInt32(Console.ReadLine());
return l;
}

string[] UrArray (int l)
{
    Console.WriteLine("Введите текст");
    string[] array = new string[l];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }

return array;
}

void PrintArray (string[] arr)
{
    Console.Write("[");
    Console.Write(string.Join(",", arr));
    Console.Write("]");
}

void Test (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Длина массива {array[i]} равна {array[i].Length}");
    }
}


int HowMany (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count ++;
        }
        
    }
    Console.WriteLine($"Количество элементовмассива, которое включает в себя 3 или менее символов = {count}");
    return count;
}
 
string[] ReadyArray (int l, string[] oldarray)
{
    string[] array = new string[l];
    int j = 0;
    for (int i = 0; i < oldarray.Length; i++)
    {
        if (oldarray[i].Length <= 3)
        {
            array [j] = oldarray[i];
            j++;
        }
    }

return array;
}

