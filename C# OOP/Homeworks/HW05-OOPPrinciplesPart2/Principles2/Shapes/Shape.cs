namespace Principles2.Shapes
{
    abstract class Shape
    {
        public decimal Height { get; set; }
        public decimal Width { get; set; }

        protected Shape(decimal height, decimal width)
        {
            this.Height = height;
            this.Width = width;
        }
        public abstract decimal CalculateSurface();
        
    }
}
