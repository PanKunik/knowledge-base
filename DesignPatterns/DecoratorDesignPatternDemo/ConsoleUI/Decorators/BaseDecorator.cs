using ConsoleUI.Components;

namespace ConsoleUI.Decorators
{
    // Base abstract decorator's class
    // By extending this class we can make other decorator's that would add new notifications
    public abstract class BaseDecorator : INotifier
    {
        private readonly INotifier _wrappe;

        public BaseDecorator(INotifier wrappe)
        {
            _wrappe = wrappe;
        }

        public virtual void Notify(string message)
        {
            _wrappe.Notify(message);
        }
    }
}
