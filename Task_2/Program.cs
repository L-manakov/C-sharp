// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.Write("Введите первое число = ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число = ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.Write("max = ");
    Console.WriteLine(firstNumber);
    Console.Write("min = ");
    Console.WriteLine(secondNumber);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(secondNumber);
    Console.Write("min = ");
    Console.WriteLine(firstNumber);
}