using ConsoleUI.Components;
using System;

namespace ConsoleUI.Decorators
{
    class SMSNotifierDecorator : BaseDecorator
    {
        // SMS Decorator - allows to extend base notifier (Email) with SMS notifications
        public SMSNotifierDecorator(INotifier wrappe) : base(wrappe) { }

        public override void Notify(string message)
        {
            // Email or other notify is send before SMS notifier
            base.Notify(message);

            Console.WriteLine("Notify was sent to SMS.");
            Console.WriteLine($"{ message } - Click here to add to calendar.");
        }
    }
}
