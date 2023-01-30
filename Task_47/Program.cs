// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*m = 3, n = 4.
0,5  7  -2  -0,2
1  -3,3  8  -9,9
8   7,8 -7,1  9*/

// 1. Метод заполнения матрицы случайными числами
void FillMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

// 2. Метод вывода матрицы на экран
void PrintMatrix(double[,] matr)
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

double[,] matrix = new double[rowsNum, colsNum];
Console.WriteLine();
FillMatrix(matrix);
PrintMatrix(matrix);