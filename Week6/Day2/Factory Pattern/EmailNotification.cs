using System;

namespace FactoryPattern
{
    internal class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Email Notification Sent: " + message);
        }
    }
}
