//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Point (double b1, double k1, double b2, double k2)
{
    double pointX = -(b1 - b2) / (k1 - k2);
    double pointY = k1 * pointX + b1;
    Console.Write($"{pointX}, {pointY}");
}

double GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = GetInfo("Введите координату b1: ");
double k1 = GetInfo("Введите координату k1: ");
double b2 = GetInfo("Введите координату b2: ");
double k2 = GetInfo("Введите координату k2: ");

Point(b1, k1, b2, k2);