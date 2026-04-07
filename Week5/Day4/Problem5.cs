using System;
using System.IO;

namespace Week5Day4
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            try
            {
                // Retrieve all system drives
                DriveInfo[] drives = DriveInfo.GetDrives();

                Console.WriteLine("Drive Information:\n");

                // Loop through each drive
                foreach (DriveInfo drive in drives)
                {
                    try
                    {
                        // Ensure drive is ready
                        if (drive.IsReady)
                        {
                            //  Display drive details
                            Console.WriteLine("Drive Name: " + drive.Name);
                            Console.WriteLine("Drive Type: " + drive.DriveType);
                            Console.WriteLine("Total Size: " + (drive.TotalSize / (1024 * 1024 * 1024)) + " GB");
                            Console.WriteLine("Free Space: " + (drive.AvailableFreeSpace / (1024 * 1024 * 1024)) + " GB");

                            // Calculate free space percentage
                            double freePercent = (double)drive.AvailableFreeSpace / drive.TotalSize * 100;

                            Console.WriteLine("Free Space %: " + freePercent.ToString("F2") + "%");

                            // Warning if below 15%
                            if (freePercent < 15)
                            {
                                Console.WriteLine("WARNING: Low Disk Space!");
                            }

                            Console.WriteLine("----------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("Drive Name: " + drive.Name);
                            Console.WriteLine("Drive is not ready.");
                            Console.WriteLine("----------------------------------");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error accessing drive " + drive.Name + ": " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}