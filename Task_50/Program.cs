// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

// 1. Метод заполнения матрицы случайными числами
void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

// 2. Метод вывода матрицы на экран
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк:  ");
int rowsNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int colsNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[rowsNum, colsNum];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

Console.Write("Введите строку матрицы: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец матрицы: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

if (pos1 < 0 || pos1 > matrix.GetLength(0) - 1 || pos2 < 0 || pos2 > matrix.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует ");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[pos1, pos2]);
}
