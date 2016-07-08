namespace Main
{
    using System;
    using Homework02_Library.Point;
    using Homework02_Library.List;
    using Homework02_Library.Matrix;

    class Startup
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Point Test\n");
            PointTest();

            Console.WriteLine("\nGeneric list test\n");
            GenericListTest();

            Console.WriteLine("\nMatrix test\n");
            MatrixTest();

        }
        static void PointTest()
        {
            var firstPoint = new Point3D(1, 1, 1);
            var secondPoint = new Point3D(1, 2, 2);

            Console.WriteLine(firstPoint);
            Console.WriteLine("{0:F2}", PointDistance.Distance(firstPoint, secondPoint));

            Console.WriteLine("Zero point: {0}", Point3D.PointO);

            var pathOfPoints = new PointPath();
            pathOfPoints.AddPoint(new Point3D(1, 2, 3));
            pathOfPoints.AddPoint(new Point3D(2, 51, 23));
            pathOfPoints.AddPoint(new Point3D(13, 12, 23));
            pathOfPoints.AddPoint(new Point3D(42, 2, 11));
            pathOfPoints.AddPoint(new Point3D(32, 2, 63));

            Console.WriteLine("Path\n" + pathOfPoints);

            PathStorage.SavePathToFile("MyPointPath.txt", pathOfPoints);
            var pathFromFile = PathStorage.ReadPathFromFile("MyPointPath.txt");

            Console.WriteLine("Path read from file\n" + pathFromFile);


        }
        static void GenericListTest()
        {
            var listForTest = new GenericList<int>();
            listForTest.Add(0);
            listForTest.Add(1);
            listForTest.Add(2);
            listForTest.Add(3);
            listForTest.Add(4);
            listForTest.Add(5);
            listForTest.Add(6);
            listForTest.Add(7);
            // Base capacity of my list is 8. Notice the auto-grow when it exceeds.
            listForTest.Add(8);
            listForTest.Add(9);

            Console.WriteLine(listForTest);
            Console.WriteLine("Item by index 3: " + listForTest.ElementAt(3));
            listForTest.RemoveAt(3);
            Console.WriteLine("Removing item by index 3: " + listForTest);
            listForTest.InsertAt(3, 100);
            Console.WriteLine("Adding item 100 at index 3: " + listForTest);
            Console.WriteLine("Search for the element with value 100. (Returns the index): " + listForTest.Find(100));
            Console.WriteLine("List max: " + listForTest.Max());
            Console.WriteLine("List min: " + listForTest.Min());
            listForTest.Clear();
            Console.WriteLine("List cleared: " + listForTest);
        }
        static void MatrixTest()
        {
            var matrixOne = new MatrixOfT<int>();
            matrixOne.FillIntMatrix();
            Console.WriteLine("Matrix one:\n" +matrixOne);
            Console.WriteLine("Item at position 0,1: "+matrixOne[0,1]);

            var matrixTwo = new MatrixOfT<int>();
            matrixTwo.FillIntMatrix();
            Console.WriteLine("Matrix two:\n" + matrixTwo);

            Console.WriteLine("Matrices +:\n" + (matrixOne + matrixTwo));
            Console.WriteLine("Matrices -:\n" + (matrixOne - matrixTwo));
            Console.WriteLine("Matrices *:\n" + (matrixOne * matrixTwo));
            if (matrixOne)
            {
                Console.WriteLine("Matrix one doesnt contain zeroes.");
            }
            else
            {
                Console.WriteLine("Matrix one contains zeroes.");
            }
            VersionAttribute MyAttribute =
            (VersionAttribute)Attribute.GetCustomAttribute(typeof(Sample), typeof(VersionAttribute));
            Console.WriteLine(MyAttribute);

        }

        [Version(2,3)]
        public class Sample
        {

        }
    }
}


