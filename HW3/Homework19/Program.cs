/*Задача 19 Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.*/

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void ChekNumb(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Число: {number} - является палиндромом.");
  }
  else Console.WriteLine($"Число: {number} - Не является палиндромом.");
}

if (number!.Length == 5){
  ChekNumb(number);
}
else Console.WriteLine($"Введите пятизначное число");
