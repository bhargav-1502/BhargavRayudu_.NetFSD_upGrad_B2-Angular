using System;

namespace SingletonPattern
{
    internal class ConfigurationManager
    {
        private static ConfigurationManager instance = null;
        private static readonly object lockObj = new object();

        public string ApplicationName { get; private set; }
        public string Version { get; private set; }
        public string DatabaseConnectionString { get; private set; }

        private ConfigurationManager()
        {
            ApplicationName = "Inventory Management System";
            Version = "1.0.0";
            DatabaseConnectionString = "Server=localhost;Database=InventoryDB;Trusted_Connection=True;";
        }

        public static ConfigurationManager GetInstance()
        {
            lock (lockObj)
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
            }
            return instance;
        }

        public void DisplayConfig()
        {
            Console.WriteLine("Application Name: " + ApplicationName);
            Console.WriteLine("Version: " + Version);
            Console.WriteLine("DB Connection: " + DatabaseConnectionString);
            Console.WriteLine("--------------------------------------");
        }
    }
}
