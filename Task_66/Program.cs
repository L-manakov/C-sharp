/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int GetSumOfRange(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
        return GetSumOfRange(firstNumber, secondNumber + 1) + secondNumber;
    else if (secondNumber > firstNumber)
        return GetSumOfRange(firstNumber + 1, secondNumber) + firstNumber;
    else
        return firstNumber;
}

Console.Write($"Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int sum = GetSumOfRange(firstNumber, secondNumber);
Console.WriteLine($"Сумма чисел в промежутке от {firstNumber} до {secondNumber} равна {sum}");