Console.Write("Введите целое число: ");

int userNumber = int.Parse(Console.ReadLine() ?? "");

int result = userNumber * userNumber;

Console.WriteLine($"{userNumber} -> {result}");


