Console.WriteLine("Введите любое целое число от 1 до 7:");
int Day = int.Parse(Console.ReadLine() ?? "");

if ((Day<1) | (Day>7))
{
    Console.Write("Ошибка");
}
else
{
    if (Day==1) { Console.Write("Понедельник"); }
    if (Day==2) { Console.Write("Вторник"); }
    if (Day==3) { Console.Write("Среда"); }
    if (Day==4) { Console.Write("Четверг"); }
    if (Day==5) { Console.Write("Пятница"); }
    if (Day==6) { Console.Write("Суббота"); }
    if (Day==7) { Console.Write("Воскресенье"); }
}