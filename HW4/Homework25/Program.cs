// Задача 25: Напишите метод, который принимает на вход
// два числа (A и B) и возводит число A в целую степень B.
// без использования math.pow

int Stepen(int numbA, int numbB)
{
   int result = 1;
    for (int i = 1; i <= numbB; i++)
    {
        result = result * numbA;
    }
    return result;
}

Console.Write("Введите число A: ");
int numbA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень B: ");
int numbB = Convert.ToInt32(Console.ReadLine());

int Expon = Stepen(numbA, numbB);
Console.Write("ответ  " + Expon);


