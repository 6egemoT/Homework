// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.


Console.Write($"Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int arraySize, int min, int max)
{
    int[] randomNumbers = new int[arraySize];
    int sumSize = 0;
    Console.Write("Получившийся массив: ");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);

        Console.Write(randomNumbers[i] + " ");

        if (i % 2 != 1)
        {
            sumSize += randomNumbers[i];
        }
    }
    return sumSize;
}

int randomNumbers = RandomNumbers(arraySize, 1, 10);

Console.WriteLine($"Сумма элементов, нечётных позиций: {randomNumbers}");