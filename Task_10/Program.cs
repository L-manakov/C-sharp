// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число = ");
int number = Convert.ToInt32(Console.ReadLine());

number = Math.Abs(number);

if (number > 99 && number < 1000)
{
    int secondDigit = number / 10 % 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Введённое число не является трёхзначным");
}