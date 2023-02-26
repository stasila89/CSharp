using System;
Console.Write("Введите целое число: ");

int userNumber = int.Parse(Console.ReadLine() ?? "");

int result = (int)Math.Pow(userNumber, 2);

Console.WriteLine($"{userNumber} -> {result}");


