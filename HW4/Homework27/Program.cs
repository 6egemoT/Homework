// Напишите программу, которая принимает на вход 
//  число и выдаёт сумму цифр в числе.


Console.Write("Введите число N: ");
int numbN = Convert.ToInt32(Console.ReadLine());

int SummaNumb(int numbN)
{

    int counter = Convert.ToString(numbN).Length;
    int temp = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        temp = numbN - numbN % 10;
        result = result + (numbN - temp);
        numbN = numbN / 10;
    }
    return result;
}

int sumNumb = SummaNumb(numbN);
Console.WriteLine("Сумма цифр : " + sumNumb);