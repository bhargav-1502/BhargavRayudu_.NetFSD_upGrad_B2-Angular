using System;

namespace FactoryPattern
{
    internal class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Push Notification Sent: " + message);
        }
    }
}
