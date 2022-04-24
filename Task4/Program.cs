//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число >0");
int x = int.Parse(Console.ReadLine());
int count = 2;
while (count <=x){
Console.Write($"{count} " );
count = count +2;
}
