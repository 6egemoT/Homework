// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1 = 4;
int y1 = 3;
int z1 = 1;
int x2 = 5;
int y2 = 7;
int z2 = -9;

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
                {
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");
