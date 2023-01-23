// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.


// 1. Введите размера массива
// int <- (string)
int EnterSizeArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return Math.Abs(size);
}

// 2. Создание массива
// int[] <- (int)
int[] CreateArray(int size)
{
    int[] arr = new int[size];
    return arr;
}

// 3. Заполнение массива случайными числами
// void <- (int[])
void FillArray(int[] randomNumbers)
{
    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = Random.Shared.Next(1,10);
    }
}

// 4. Нахождение произведения пар чисел
// int[] <- int[]
int[] ProductPairsNumbers(int[] array)
{
    int[] result = new int[array.Length/2];
    for (int i = 0; i < array.Length/2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    return result;
}

// 5. Печать массивов
// string <- (int[])
string PrintArray(int[] array)
{
    string output = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        output += $"{array[i]} ";
    }
    return output;
}


int size = EnterSizeArray();
int[] arr = CreateArray(size);
FillArray(arr);
string arrPrint = PrintArray(arr);
Console.WriteLine($"Исходный массив: {arrPrint}");
int[] newArr = ProductPairsNumbers(arr);
string newArrPrint = PrintArray(newArr);
Console.WriteLine($"Новый массив: {newArrPrint}");
