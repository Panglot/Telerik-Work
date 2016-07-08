namespace Principles2.Shapes
{
    class Triangle : Shape
    {
        public Triangle(decimal height, decimal width) : base(height, width)
        {
        }

        public override decimal CalculateSurface()
        {
            return this.Height * this.Width / 2;
        }
    }
}
