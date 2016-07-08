namespace Homework02_Library.Point
{
    public class PointPath // The name is PointPath instead of Path only because there is conflict with System.IO.Path.
    {

        public int Count { get; set; } = 0;

        public PointPath()
        {

        }

        public Point3D[] Content { get; set; } = new Point3D[8];

        public void AddPoint(Point3D point)
        {
            if (Count == Content.Length)
            {
                Point3D[] temp = Content;
                Content = new Point3D[Count + 8];
                for (int i = 0; i < temp.Length; i++)
                {
                    Content[i] = temp[i];
                }
            }
            Content[Count++] = point;
        }
        public void RemovePoint()
        {
            Content[Count--] = new Point3D();
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Count-1; i++)
            {

                result += Content[i];
                result += "\n";
            }
            result += Content[Count - 1];
            return result;
        }
    }
}
