// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// Метод нахождения расстояния между двумя точками в пространстве

double GetDistance(double x1, double y1, double z1,
                   double x2, double y2, double z2)
{
    double dx = x2 - x1;
    double dy = y2 - y1;
    double dz = z2 - z1;
    double result = Math.Round(Math.Sqrt(dx * dx + dy * dy + dz * dz), 2);
    return result;
}

Console.Write("Введите координату x первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = GetDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками: ({x1}; {y1}; {z1}) и ({x2}; {y2}; {z2}) = {distance}");