using System;
using ConsoleTest.Infrastructure;

namespace ConsoleTest.Infrastructure.Shaping
{
    internal class Circle : Shape
    {
        private const double Pi = Math.PI;
        private double r { get; }
        public Circle(double r) => this.r = r;
        /// <summary>
        /// Площадь окружности
        /// </summary>
        /// <returns></returns>
        internal override int GetArea() => (int)(Pi * (r * r));
    }
}
