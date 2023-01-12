// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());
int initialNumber = 1;

while (initialNumber <= N)
{
    if (initialNumber % 2 == 0)
    {
        Console.Write(initialNumber + " ");
    }
    initialNumber++;
}