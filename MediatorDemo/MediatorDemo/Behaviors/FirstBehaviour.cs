using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorDemo.Behaviors
{
    public class FirstBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            // This part would be executed before going to the next PipelineBehavior (or Handler if there isn't any PipelineBehaviors)
            System.Console.WriteLine("First behavior - before");
            // Calling next PipelineBehavior (or Handler)
            var response = await next();
            //This part would be executed before going to the next PipelineBehavior (or Handler)
            System.Console.WriteLine("First behavior - after");

            // Return response value
            return response;
        }
    }
}