// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// . Напишите программу вычисления модуля числа.
// 2 -> 2
// -3 -> 3
// -7 -> 7
// *. Напишите программу, которая на вход принимает значение, а
// на выходе показывает обратное значение.
// 1 -> 1
// 2 -> 0.5
// 0.25 -> 4
Console.WriteLine("Введите число");
string s = Console.ReadLine();
int x = int.Parse(s);
if (x < 0) x = -x;
Console.WriteLine("Модуль введенного числа = " + x);
Console.WriteLine("Введите число");
s =  Console.ReadLine();
double y = double.Parse(s);
Console.WriteLine("Обратное значение = " + 1/y);// так работает