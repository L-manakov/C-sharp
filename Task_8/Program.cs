// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());
int initialNumber = 2;

while (initialNumber <= n)
{
    if (initialNumber % 2 == 0)
    {
        Console.Write(initialNumber + " ");
    }
    initialNumber = initialNumber +2;
}