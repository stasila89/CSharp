using System;
Console.Write("Введите целое число: ");

int userNumber = int.Parse(Console.ReadLine() ?? "");

double result = (int)Math.Pow(userNumber, 2);

Console.WriteLine($"{userNumber} -> {result}");


