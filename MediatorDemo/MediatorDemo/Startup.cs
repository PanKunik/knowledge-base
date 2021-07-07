using MediatorDemo.Queries;
using MediatR;
using System.Threading.Tasks;

namespace MediatorDemo
{
    public class Startup
    {
        private readonly IMediator _mediator;

        public Startup(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Run()
        {
            var request = new GetProductsQuery() { Name = "Se" };
            // Calling Send() method of the MediatR package.
            // This method maps Query/Command to Handler by interfaces 'IRequest<>' and 'IRequestHandler<,>'
            var products = await _mediator.Send(request);
        }
    }
}
