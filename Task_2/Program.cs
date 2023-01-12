// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.Write("Введите число a = ");
int a = Int32.Parse(Console.ReadLine());

Console.Write("Введите число b = ");
int b = Int32.Parse(Console.ReadLine());

var max = a;
var min = b;

if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.WriteLine(b);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.WriteLine(a);
}