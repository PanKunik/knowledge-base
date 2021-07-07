using Domain.Entities;
using Domain.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorDemo.Queries
{
    // Query - can contain fields that are used in Handlers (e.g. to filter data)
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
    }

    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductRepository _repository;

        public GetProductsQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        // Handler - taking the Query/Command object and use it to Handle it (return data | save to database | update something)
        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetProducts(x => (x.ID == request.ProductId || request.ProductId == 0)
                                                   && (x.Name.Contains(request.Name ?? "") || string.IsNullOrEmpty(request.Name))
                                                   && (x.Value <= request.Value || request.Value == 0M));
            return result;
        }
    }
}
