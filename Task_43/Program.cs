// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2. Значения k1, b1, k2 и b2 задаются пользователем.
// Тестовые значения: k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5).

// 1. Получение значений
double GetValues(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

// 2. Поиск точки пересечения
(double, double) GetIntersectionPoint(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

System.Console.WriteLine("Введите данные:");
double k1 = GetValues("k1 = ");
double b1 = GetValues("b1 = ");
double k2 = GetValues("k2 = ");
double b2 = GetValues("b2 = ");

var res = GetIntersectionPoint(k1, b1, k2, b2);
Console.WriteLine($"Точка пересечения двух прямых --> {res}");