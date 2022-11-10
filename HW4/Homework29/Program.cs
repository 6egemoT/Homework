// Напишите программу, которая задаёт массив из N элементов и
// выводит их на экран.


Console.WriteLine("ВВедите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] FillArray (int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int[] numbers = FillArray(size);
Console.WriteLine(numbers);