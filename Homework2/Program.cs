int numberA = new Random().Next(-50, 50); // в А и В любые числа
int numberB = new Random().Next(-50, 50);
int max = 0;
int min = 0;
Console.WriteLine(numberA);
Console.WriteLine(numberB);
if (numberA > numberB)
{
    max = numberA;
    min = numberB;
}
else
{
    max = numberB;
    min = numberA;
}
Console.Write("max = " + max + ",");
Console.Write("min = " + min);
