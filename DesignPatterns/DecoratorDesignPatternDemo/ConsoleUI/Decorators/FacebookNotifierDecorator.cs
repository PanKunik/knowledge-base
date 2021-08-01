using ConsoleUI.Components;
using System;

namespace ConsoleUI.Decorators
{
    public class FacebookNotifierDecorator : BaseDecorator
    {
        // Facebook Decorator - allows to extend base notifier (Email) with Facbook notifications
        public FacebookNotifierDecorator(INotifier wrappe) : base(wrappe) { }

        public override void Notify(string message)
        {
            // Email or other notify is send before Facebook notifier
            base.Notify(message);

            Console.WriteLine("Notify was send to Facebook user.");
            Console.WriteLine($"{ message } - Click here to add to notifications.");
        }
    }
}
