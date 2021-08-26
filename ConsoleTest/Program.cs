using System;
using ConsoleTest.Infrastructure.Shaping;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle ShapeCircel = new Circle(5);
            Square ShapeSquare = new Square(124);
            Console.WriteLine($"Площадь окружности: {ShapeCircel.GetArea(), -12}");
            Console.WriteLine($"Площадь квадрата: {ShapeSquare.GetArea(), -12}");
        }
    }
}
