// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число");
string s = Console.ReadLine();
int x = int.Parse(s);
Console.WriteLine("Введите число");
s= Console.ReadLine();
int y = int.Parse(s);
Console.WriteLine("Введите число");
s= Console.ReadLine();
int z = int.Parse(s);
int max = x;
if (y>max) max =y;
if (z>max) max = z;
Console.WriteLine("Максимальное число - " + max);
