using System;

namespace ConsoleUI.Components
{
    // This is our main component that is used in aour application.
    // It implements the 'INotifier' interface.
    class EmailNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine("Notify was send on email.");
            Console.WriteLine(message);
        }
    }
}
