using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorDemo.Behaviors
{
    public class SecondBehavior<T1, T2> : IPipelineBehavior<T1, T2>
    {
        public async Task<T2> Handle(T1 request, CancellationToken cancellationToken, RequestHandlerDelegate<T2> next)
        {
            System.Console.WriteLine("Second behavior - before");
            var response = await next();
            System.Console.WriteLine("Second behavior - after");

            return response;
        }
    }
}