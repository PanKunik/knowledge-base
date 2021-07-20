using Domain.Common;

namespace Domain.Factories
{
    // FACTORY METHOD PATTERN
    // This is main class (base) marked as abstract.
    // Factory method pattern is used when you need to dynamicly create instance of a class
    // that is from one family (implements specified interface or extends a class).
    // Used then creation of an instance is more complicated than just calling parameterless contructor.
    public abstract class Logistics
    {
        // This method is marked as abstract, so Factory class can describe how to create instance of a specified class.
        protected abstract ITransport CreateTransport();

        // This method is common in all classes (from an interface). This is method that would be used in client's code.
        // Client doesn't know which factory he uses.
        public void Deliver()
        {
            CreateTransport().DeliverPackage();
        }
    }
}
