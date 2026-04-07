using System;
using System.IO;

namespace Week5Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Root Directory Path: ");
                string path = Console.ReadLine();

                // Validate path
                if (string.IsNullOrWhiteSpace(path) || !Directory.Exists(path))
                {
                    Console.WriteLine("Invalid directory path!");
                    return;
                }

                // Create DirectoryInfo object
                DirectoryInfo rootDir = new DirectoryInfo(path);

                Console.WriteLine("\nSubdirectories and File Counts:\n");

                //  Get all subdirectories
                DirectoryInfo[] subDirs = rootDir.GetDirectories();

                // Loop through each directory
                foreach (DirectoryInfo dir in subDirs)
                {
                    try
                    {
                        //  Count files in each directory
                        FileInfo[] files = dir.GetFiles();

                        Console.WriteLine("Folder: " + dir.Name);
                        Console.WriteLine("File Count: " + files.Length);
                        Console.WriteLine("---------------------------");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine("Folder: " + dir.Name);
                        Console.WriteLine("Access Denied!");
                        Console.WriteLine("---------------------------");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}