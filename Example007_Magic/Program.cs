Console.Clear();
//Console.SetCursorPosition(20, 10);
//Console.WriteLine("*");

int xa = 1, ya = 1,
    xb = 80, yb = 1,
    xc = 1, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");

int x = xc, y = yc;

int count = 0;

while (count < 10000)
{
    int cube = new Random().Next(0, 3);   // [0;3) 0, 1, 2
    if (cube == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (cube == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (cube == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count = count + 1;
}