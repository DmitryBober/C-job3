﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
int lenght = number.Length;

if (number[0] == number[4] && number[1] == number[3])
    {
        Console.Write($"{number} - Палиндром");
    }
    else
    {
        Console.Write($"{number} - Не палиндром");
    }