﻿/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.*/

int x = 34869;
int i = 1; // десятки (т.е. если 143 i = 10^2 cтепени)
int y = 0; // буфер х
if (x < 99)
{
    Console.WriteLine("нет третьей цифры");
}
y = x; // сохраняем х
while (x > 10) // х>10 из за десятков
{
    x = x / 10;  // три раза
    i = i * 10;  
}

//вычислим 1 цифру
int a = (y / i);
//вычислим значения со 2 цифры
int b = (y - a * i);
//вычислим 2 цифру
int b1 = b / (i / 10);
//вычислим значения с 3 цифры
int c = (b - b1 * i/10);
//вычислим 3 цифру
int c1 = c / (i / 100);

Console.WriteLine(i);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(b1);
Console.WriteLine(c);
Console.WriteLine("Результат=" + c1);

