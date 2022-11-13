// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] numbers = new int[10];

void FillArray(int[] array, int min, int max) // Заполняем массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array)   // выводим маассив в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int NumberOfEven(int[] array)  // считаем четные в рандомном массиве
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            even++;
        }
    }
    return even;
}

FillArray(numbers, 100, 1000);  // задаем интревал
WriteArray(numbers);            
Console.WriteLine();            // выводим в консоль

int even = NumberOfEven(numbers);
Console.WriteLine($"Чётных чисел в массиве: {even}"); // вывод количества четных чмсел