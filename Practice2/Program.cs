 Console.WriteLine("Введите любое целое число от 1 до 7:");
int Day = int.Parse(Console.ReadLine() ?? "");

if ((Day<1) || (Day>7)) Console.Write("Ошибка");
else if (Day==1) Console.Write($"{Day} -> Понедельник");
else if (Day==2) Console.Write($"{Day} -> Вторник");
else if (Day==3) Console.Write($"{Day} -> Среда"); 
else if (Day==4) Console.Write($"{Day} -> Четверг"); 
else if (Day==5) Console.Write($"{Day} -> Пятница");
else if (Day==6) Console.Write($"{Day} -> Суббота"); 
else if (Day==7) Console.Write($"{Day} -> Воскресенье"); 