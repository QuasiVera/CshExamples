int count = 0;
double distance = 10000;                // метры
double firstFriendSpeed = 1;            // м/с
double secondFriendSpeed = 2;           // м/с
double dogSpeed = 5;                    // м/с
int friend = 2;                         // направление движения: к другу 1 или 2
double time;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
    
}
Console.WriteLine(count);
