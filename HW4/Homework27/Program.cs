// Напишите программу, которая принимает на вход 
//  число и выдаёт сумму цифр в числе.


Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine()); 

void Summa(string[] args)
{
    int sum = 0;
    while (N > 0)
    {
        sum += N % 10;
        N /= 10;
    }
    Console.WriteLine(sum);
}



int Expon = Stepen(numbA, numbB);
Console.Write("ответ  " + Summa(string[] args));