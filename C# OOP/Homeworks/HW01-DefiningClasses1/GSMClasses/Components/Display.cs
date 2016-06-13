namespace GSMClasses.Components
{
    public class Display
    {
        public double Size { get; set; }
        public int ColorCapacity { get; set; }

        public Display()
        {
                
        }
        public Display(double size, int colorcap)
        {
            this.Size = size;
            this.ColorCapacity = colorcap;
        }
    }
}
