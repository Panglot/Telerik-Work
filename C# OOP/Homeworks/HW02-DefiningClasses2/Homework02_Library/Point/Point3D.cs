namespace Homework02_Library.Point
{
    public struct Point3D
    {
        private readonly static Point3D pointO = new Point3D(0,0,0);

        public double XCoord { get; set; }
        public double YCoord { get; set; }
        public double ZCoord { get; set; }
        public static Point3D PointO { get; }
        
        public Point3D(double x, double y, double z)
        {
            this.XCoord = x;
            this.YCoord = y;
            this.ZCoord = z;
        }

        public override string ToString()
        {
            return $"{{{this.XCoord}, {this.YCoord}, {this.ZCoord}}}";
        }

    }
}
