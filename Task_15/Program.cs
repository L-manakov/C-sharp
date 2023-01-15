// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число, обозначающее день недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek == 6 || dayOfWeek == 7)
{
    Console.WriteLine("Это выходной день.");
}
else if (dayOfWeek < 1 || dayOfWeek > 7)
{
    Console.WriteLine("Такого дня недели не существует.");
}
else 
{
    Console.WriteLine("Это рабочий день.");
}