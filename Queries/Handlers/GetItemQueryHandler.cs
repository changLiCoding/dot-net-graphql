using MediatR;
using dot_net_graphql.Models;
using dot_net_graphql.Queries;

namespace dot_net_graphql.Queries.Handlers;

public class GetItemQueryHandler : IRequestHandler<GetItemQuery, Item>
{
    public Task<Item> Handle(GetItemQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new Item { Id = request.Id, Name = "Demo" });
    }
}