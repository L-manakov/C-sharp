/* Напишите программу, которая выводит массив из N элементов, 
заполненный нулями и единицами в случайном порядке. Самое левое число != 0
Данный массив есть двоичное представление десятичного числа [1,0,1,1,0,1,0,0]
Реализовать перевод двоичного числа в десятичное. */

// 1. Ввод N
// int <- (string)
int EnterNumber()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

// 2. Создание массива
// int[] <- (int)
int[] CreateArray(int number)
{
    int[] arr = new int[number];
    return arr;
}

// 3. Заполнение массива 0 и 1
// void <- (int[])
void FillArray(int[] binNumber)
{
    for (int i = 0; i < binNumber.Length; i++)
    {
        binNumber[0] = 1;
        binNumber[i] = Random.Shared.Next(2);
    }
}

// 4. Печать массива
// string <- (int[])
string PrintArray(int[] numbers)
{
    string output = String.Empty;

    for (int i = 0; i < numbers.Length; i++)
    {
        output = output + $"{numbers[i]} ";
    }
    return output;
}

// 5. Конвертация из 2-ого в 10-ое
// int <- (int[])
int BinToDec(int[] arrBin)
{
    int exponent = arrBin.Length - 1;
    int result = 0;
    for (int i = 0; i < arrBin.Length; i++)
    {
        result = result + arrBin[i] * Convert.ToInt32(Math.Pow(2, exponent));
        exponent--;
    }
    return result;
}

// 6. Вывод результата конвертации на экран
// string <-  (int[] , int)
string GoodPrint(int[] arr, int result)
{
    return $"{String.Join("", arr)} >> {result}";
}

int number = EnterNumber();
int[] arr = CreateArray(number);
FillArray(arr);
string binPrint = PrintArray(arr);
int result = BinToDec(arr);
Console.WriteLine(binPrint);
Console.WriteLine(GoodPrint(arr, result));