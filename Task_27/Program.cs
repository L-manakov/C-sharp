// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Функция получения суммы чисел

int SumDigits(int number)
{
    int result = 0;
    int temp = number;
    while (temp != 0)
    {
        result = result + temp % 10;
        temp = temp / 10;
    }
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

number = Math.Abs(number);
Console.WriteLine($"Сумма цифр в числе {number} равна {SumDigits(number)}");
