//3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
if(x%2==0) Console.WriteLine("Это четное число");
else Console.WriteLine("Это нечетное число");
