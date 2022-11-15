// 
int number = new Random().Next(10, 100);

int a = number / 10;
int b = number % 10;

int max;

if (a > b)
    max = a;
else 
    max = b;

Console.WriteLine($"{number} -> {max}");

//double result = (double) 23/10;           -> чтобы получить дробный результат от деления
//Console.WriteLine($"result = {result} ");