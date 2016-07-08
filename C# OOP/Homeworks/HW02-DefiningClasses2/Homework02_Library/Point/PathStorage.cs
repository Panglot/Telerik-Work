namespace Homework02_Library.Point
{
    using System;
    using System.Linq;
    using System.IO;

    public static class PathStorage
    {
        public static void SavePathToFile(string filePath, PointPath path)
        {
            TextWriter writer = new StreamWriter(filePath);
            writer.WriteLine(path.Count);
            foreach (var item in path.Content)
            {
                writer.WriteLine(item);
            }
            writer.Close();
           
        }
        public static PointPath ReadPathFromFile(string filePath)
        {
            string[] content = File.ReadAllLines(filePath);
            

            PointPath forReturn = new PointPath();

            for (int i =1 ; i <= int.Parse(content[0]); i++)
            {
                double[] numbers = content[i].Split(new char[] { ' ', ',', '{', '}' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                forReturn.AddPoint(new Point3D(numbers[0], numbers[1], numbers[2]));
            }

            forReturn.Count = int.Parse(content[0]);

            return forReturn;
        }
    }
}
