// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

number = Math.Abs(number);

if (number < 100)
{
    Console.WriteLine("У числа нет третьей цифры.");
}
else 
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}