// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Тестовые значения 0, 7, 8, -2, -2 -> 2 | 1, -7, 567, 89, 223-> 4

int GetCountPositiveNum(int numbers)
{
    int naturals = 0, counter = 0;
    while (counter < numbers)
    {
        Console.Write($"Введите {counter + 1} число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) naturals++;
        counter++;
    }
    return naturals;
}

Console.Write("Количество вводимых чисел M: ");
int countNum = Convert.ToInt32(Console.ReadLine());

int positiveNum = GetCountPositiveNum(countNum);
Console.WriteLine($"Введено {positiveNum} положительных числа");