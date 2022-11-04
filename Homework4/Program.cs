// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

int numberA = new Random().Next(-50, 50);
int numberB = new Random().Next(-50, 50);
int numberC = new Random().Next(-50, 50);
int max = numberA;

Console.WriteLine(numberA);
Console.WriteLine(numberB);
Console.WriteLine(numberC);

if (numberB > numberA)
{
    max = numberB;
}
if (numberC > numberB)
{
    max = numberB;
}
Console.Write("max = " + max + ",");