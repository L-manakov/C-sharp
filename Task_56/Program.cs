/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка.*/

// 1. Метод создания и заполнения матрицы случайными числами и вывода на экран:
void CreateMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// 2. Метод нахождения строки с наименьшей суммой элементов:
int GetRowMinSum(int[,] matr)
{
    int rowMinSum = 0;
    int row = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки = {sum}");

        if (i == 0) 
        {
        rowMinSum = sum;
        row = i;
        }
        else if (rowMinSum > sum)
        {
            rowMinSum = sum;
            row = i;
        }
    }
    return row;
}

Console.Write("Введите число строк матрицы: ");
int rowsNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов матрицы: ");
int colsNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[rowsNum, colsNum];
CreateMatrix(matrix);
Console.WriteLine();

int row = GetRowMinSum(matrix);
Console.WriteLine($"Минимальная сумма элементов в {row + 1} строке");
