using System;

namespace FactoryPattern
{
    internal class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS Notification Sent: " + message);
        }
    }
}

