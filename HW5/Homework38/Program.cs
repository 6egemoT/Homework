// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.


double[] arrayNaturalNumber = new double[6];
  for (int i = 0; i < arrayNaturalNumber.Length; i++ )
  {
    arrayNaturalNumber[i] = new Random().Next(1, 1000);
    Console.Write(arrayNaturalNumber[i] + " ");
  }

double maxNumber = arrayNaturalNumber[0];
double minNumber = arrayNaturalNumber[0];

  for (int i = 1; i < arrayNaturalNumber.Length; i++)
  {
    if (maxNumber < arrayNaturalNumber[i])
    {
      maxNumber = arrayNaturalNumber[i];
    }
        if (minNumber > arrayNaturalNumber[i])
    {
      minNumber = arrayNaturalNumber[i];
    }
  }

  double  conclusion = maxNumber - minNumber;

   Console.WriteLine($"\nРазница между max и min: { conclusion}");
