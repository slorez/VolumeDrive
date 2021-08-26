using System;
using ConsoleTest.Infrastructure;

namespace ConsoleTest.Infrastructure.Shaping
{
   
    internal class Square : Shape
    {
        private int side { get; }
        public Square(int a) => side = a;
        /// <summary>Площадь квадрата</summary>
        internal override int GetArea() => side * side;
    }
}
