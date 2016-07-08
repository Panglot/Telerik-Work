namespace Principles2.Shapes
{
    class Rectangle:Shape
    {
        public Rectangle(decimal height, decimal width) : base(height, width)
        {
        }

        public override decimal CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
