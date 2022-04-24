//1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число");
string s = Console.ReadLine();
int x = int.Parse(s);
Console.WriteLine("Введите число");
s= Console.ReadLine();
int y = int.Parse(s);
if (x<y){
    Console.WriteLine( y + " - большее число, " + x + " - меньшее число");
    
}
else {
    Console.WriteLine( x + " - большее число, " + y+ " - меньшее число");
}