Console.WriteLine("Введите первое число: ");
int userNumber1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите второе число: ");
int userNumber2 = int.Parse(Console.ReadLine() ?? "");
if (userNumber1 == userNumber2 * userNumber2)
{
    Console.WriteLine("Да");
}
    else
{
    Console.WriteLine("Нет");
}
//Console.WriteLine($"{userNumber1} , {userNumber2}");


