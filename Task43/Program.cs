// Задача 43: 
// 1.Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// 2.значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double PointX(int b1, int k1, int b2, int k2)
{
    double x = default;
    x = ((double)b2 - (double)b1) / ((double)k1 - (double)k2);
    return x;
}

double PointY(double x, int k1, int b1)
{
    double y = 0;
    y = (double)k1 * x + (double)b1;
    return y;
}

double pointX = Math.Round(PointX(b1, k1, b2, k2), 2, MidpointRounding.ToZero);
double pointY = Math.Round(PointY(pointX, k1, b1), 2, MidpointRounding.ToZero);
Console.Write($"{pointX},{pointY}");