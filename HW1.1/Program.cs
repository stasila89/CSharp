Console.Clear();
int count = 0;
int distance = 10000;
int firstFriendspeed = 2;
int secondFriendspeed = 1;
int dogSpeed = 5;
int friend = 2;
int time;
while (distance > 10 )
{
    if (friend == 1) 
    {
        time = distance / (dogSpeed + firstFriendspeed);
        friend = 2;
    }
    else 
    {
       time = distance / (dogSpeed + secondFriendspeed);
        friend = 1; 
    }

    distance = distance - (firstFriendspeed - secondFriendspeed) * time;
       count++;

}

Console.Write("Собака пробежала ");
Console.Write(count);
Console.WriteLine(" раз(а)!");
