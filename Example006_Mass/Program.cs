Console.WriteLine("Введите целое число №1 и нажмите enter");
string aa = Console.ReadLine() ?? "";
Console.WriteLine("Введите целое число №2 и нажмите enter");
string bb = Console.ReadLine() ?? "";
Console.WriteLine("Введите целое число №3 и нажмите enter");
string cc = Console.ReadLine() ?? "";
Console.WriteLine("Введите целое число №4 и нажмите enter");
string dd = Console.ReadLine() ?? "";
Console.WriteLine("Введите целое число №5 и нажмите enter");
string ee = Console.ReadLine() ?? "";
int a = Convert.ToInt32(aa);
int b = Convert.ToInt32(bb);
int c = Convert.ToInt32(cc);
int d = Convert.ToInt32(dd);
int e = Convert.ToInt32(ee);
int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.Write("max = ");
Console.Write(max);
