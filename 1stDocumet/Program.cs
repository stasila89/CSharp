using System.Data.SqlTypes;
Console.Write("Введите целое число: ");

string userInputStr = Console.ReadLine() ?? "";

int userNumber = int.Parse(userInputStr);

Console.WriteLine(userInputStr);


