﻿/*Задача 10: Напишите программу, которая принимает на 
вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/

Console.WriteLine("Введите трех значное число");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 99 || x < 999)
{
    int a = (x / 100);
    int b = (x - a * 100) / 10;
    Console.WriteLine(b);
}