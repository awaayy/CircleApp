using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите радиус круга: ");
        if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
        {
            Console.WriteLine($"Длина окружности: {Circle.CalculateCircumference(radius):F2}");
            Console.WriteLine($"Площадь круга: {Circle.CalculateArea(radius):F2}");
        }
        else
        {
            Console.WriteLine("Ошибка: Введите положительное число.");
        }
    }
}

public class Circle
{
    public static double CalculateCircumference(double radius) => 2 * Math.PI * radius;
    public static double CalculateArea(double radius) => Math.PI * Math.Pow(radius, 2);
}
