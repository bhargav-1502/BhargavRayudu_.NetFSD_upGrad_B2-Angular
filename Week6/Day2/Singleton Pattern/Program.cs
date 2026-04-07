using System;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ConfigurationManager config1 = ConfigurationManager.GetInstance();
            config1.DisplayConfig();

            
            ConfigurationManager config2 = ConfigurationManager.GetInstance();
            config2.DisplayConfig();

          
            if (config1 == config2)
            {
                Console.WriteLine("Both instances are SAME (Singleton works)");
            }
            else
            {
                Console.WriteLine("Different instances (Error)");
            }

            Console.ReadLine();
        }
    }
}
