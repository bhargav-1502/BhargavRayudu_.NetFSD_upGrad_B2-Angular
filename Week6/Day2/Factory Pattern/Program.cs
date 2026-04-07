using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationFactory factory = new NotificationFactory();

            // Email
            var emailNotification = factory.CreateNotification("email");
            emailNotification.Send("Welcome to our service!");

            // SMS
            var smsNotification = factory.CreateNotification("sms");
            smsNotification.Send("Your OTP is 12345");

            // Push
            var pushNotification = factory.CreateNotification("push");
            pushNotification.Send("You have a new alert!");

            Console.ReadLine();
        }
    }
}
