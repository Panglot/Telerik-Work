namespace Principles2.Shapes
{
    using System;

    class Square: Shape
    {
        public Square(decimal height, decimal width)
            :base(squareCheck(height, width), width)  {}

               private static decimal squareCheck ( decimal height, decimal width)
        {
            if (height!=width)
            {
                throw new ArgumentException("Square must have the same height as width. Enter valid values or use Rectangle class.");
            }
            return height;
        }

        public override decimal CalculateSurface()
        {
            return this.Height*this.Height;
        }
    }
}
