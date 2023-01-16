// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// Метод проверки на логическое занчаение: "true" или "false"

bool Check(int number)
{
    int invertedNumber = 0;
    int temp = number;

    while (number > 0)
    {
        int remains = number % 10;
        number = number / 10;
        invertedNumber = invertedNumber * 10 + remains;
    }
    return temp == invertedNumber;
}

// Решение выполняет условие задачи для проверки 5-ти значного числа.
// Но также работает для любого числа в системе Int32.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

number = Math.Abs(number);

if (number < 10000 || number >= 100000)
{
    Console.WriteLine("Введено неверное число, введите пятизначное число.");
}
else 
{
    Console.WriteLine("Число является палиндромом: " + Check(number));
}
