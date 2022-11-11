// 1. Получить строку, содержащую число
Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? ""; // проверка на null (warning S8600)

// 2. Преобразовать строку в число
int number = int.Parse(userInput);

// 3. Возводим число в квадрат
int result = number*number;

// 4. Выводим результат в консоль
Console.WriteLine($"{number} -> {result}");     // $"{number} -> {result}" интерполяция строк
