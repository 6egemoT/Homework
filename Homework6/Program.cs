/* Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка). */

int numb = new Random().Next(-50, 50);

Console.WriteLine(numb);
if (numb % 2 == 0)
{
    Console.WriteLine(numb + "Число является четным");
}
else
{
    Console.WriteLine(numb + "Число является не четным");
}


