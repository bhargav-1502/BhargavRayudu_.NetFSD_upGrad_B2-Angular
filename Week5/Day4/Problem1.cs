using System;
using System.IO;
using System.Text;

namespace Week5Day4
{
    internal class Program1
    {
        static void Main()
        {
            string filePath = "C:\\Users\\Public\\log.txt";

            try
            {
                while (true)
                {
                    Console.WriteLine("Enter your message:");
                    string message = Console.ReadLine();

                    if (message.ToLower() == "exit")
                        break;

                    byte[] data = Encoding.UTF8.GetBytes(message + Environment.NewLine);

                    using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                    {
                        fs.Write(data, 0, data.Length);
                    }

                    Console.WriteLine("Message saved successfully!");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No permission to access file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}