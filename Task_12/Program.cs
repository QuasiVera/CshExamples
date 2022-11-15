Console.WriteLine("Введите число 1: ");
string inputNumber1 = Console.ReadLine() ?? "";

Console.WriteLine("Введите число 2: ");
string inputNumber2 = Console.ReadLine() ?? "";

int number1 = int.Parse(inputNumber1);
int number2 = int.Parse(inputNumber2);

int result = number1 % number2;
if (result==0)
{
    Console.WriteLine($"{number1}, {number2} -> кратно");
}
else
{
    Console.WriteLine($"{number1}, {number2} -> не кратно, остаток = {result}");
}

