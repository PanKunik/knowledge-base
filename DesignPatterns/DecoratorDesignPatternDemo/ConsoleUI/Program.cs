using ConsoleUI.Components;
using ConsoleUI.Decorators;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // If we want to expand out notifications to other services (like Facebook, SMS, Slack, etc.)
            // We have to extend our Email class. To do it without modifying this class we could make
            // Combination of all our notifying services, but it would end up on adding
            // Too much classes. We can d it with Decorator design pattern.
            Console.WriteLine("-- Without decorator --");
            INotifier emailNotifier = new EmailNotifier();
            emailNotifier.Notify("You have a meeting tomorrow at 7 A.M.");

            Console.WriteLine("\n\r");
            Console.WriteLine("-- With decorator --");

            // For e.g. if we want to use notifications on Email with SMS notifications we would have to create
            // Class 'EmailAndSMSNotifications' - every combination we would want to use would have to has it's own class.
            // With Decorator we can wrapp object in other object with additional feature.
            // We can make as many wrapps as we need.
            var superNotifier = new SMSNotifierDecorator(new SlackNotifierDecorator(new FacebookNotifierDecorator(new SMSNotifierDecorator(emailNotifier))));
            superNotifier.Notify("You have a meeting tomorrow at 7 A.M.");
        }
    }
}
