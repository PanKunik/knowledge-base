using ConsoleUI.Components;
using System;

namespace ConsoleUI.Decorators
{
    public class SlackNotifierDecorator : BaseDecorator
    {
        // Slack Decorator - allows to extend base notifier (Email) with Slack notifications
        public SlackNotifierDecorator(INotifier wrappe) : base(wrappe) { }

        public override void Notify(string message)
        {
            // Email or other notify is send before Slack notifier
            base.Notify(message);

            Console.WriteLine("Notify was sent to Slack App.");
            Console.WriteLine($"{ message } - Click here to add to To-Do list.");
        }
    }
}
