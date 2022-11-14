// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Вводим количество чисел ");
int Number = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[Number];

void InputNumbers(int Number)
{
    for (int i = 0; i < Number; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Selection(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(Number);

Console.WriteLine($"Введено чисел больше 0: {Selection(arrayNumbers)} ");

