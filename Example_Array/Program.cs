

int a1 = UserCoord("Введите число 1: ");
int b1 = UserCoord("Введите число 2: ");
int c1 = UserCoord("Введите число 3: ");
int a2 = 29;
int b2 = 22;
int c2 = 13;
int a3 = 17;
int b3 = 23;
int c3 = 14;

//int max1 = Max(a1,b1,c1);
int max = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));

Console.WriteLine(max);


//-----------------------------Методы-------------------------
//----------------Ввод данных
static int UserCoord(string messageToUser) 
{
 Console.Write(messageToUser); 
 try 
    {
 return int.Parse(Console.ReadLine() ?? ""); 
    }
 catch (Exception exc) 
    {
 Console.WriteLine($"Ошибка ввода данных! {exc.Message}"); 
 return 0; 
    }
}

//--------------Нахождение максимального
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > arg2) result = arg3;
    return result;
}
