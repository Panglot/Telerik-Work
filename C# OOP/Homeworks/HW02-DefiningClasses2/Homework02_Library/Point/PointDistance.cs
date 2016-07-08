namespace Homework02_Library.Point
{
    using System;

    public static class PointDistance
    {
        public static double Distance(Point3D point1, Point3D point2)
        {
            return Math.Sqrt(Math.Pow((point2.XCoord - point1.XCoord),2) + Math.Pow((point2.YCoord - point1.YCoord), 2) + Math.Pow((point2.ZCoord - point1.ZCoord), 2));
        }
    }
}
