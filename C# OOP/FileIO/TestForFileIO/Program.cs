namespace TestForFileIO
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            // By creating new instance of TextWriter we open the file we pointed
            // at in the constructor. Adding true to the constructor allows you to 
            // add text without overwriting the file. Without it overwrites it.
            TextWriter wtf = new StreamWriter(@"test.txt", true);

            //Write line acts similar to Console.WriteLine but adds a whole line to the file.
            wtf.WriteLine("Ooo zemi be"); 
            wtf.WriteLine("Zemi si pak. Spam vuv fila.");

            // Closes the file. If we dont close the file errors will occur when 
            // trying to read from the file afterwards. If we want to open file 
            // again we will need to create new instance of textWriter.
            wtf.Close();

            //File.ReadAllLines reads the file and returns array of string. 
            // Every member of the array represents a line from the file. 
            // File.ReadAllText reads the file and returns the file as single string.
            string[] something = File.ReadAllLines("test.txt"); 
            Console.WriteLine(something.Length);

        }
    }
}
