using MediatR;
using dot_net_graphql.Models;
using dot_net_graphql.Commands;

namespace dot_net_graphql.Commands.Handlers;

public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, Item>
{
    public Task<Item> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new Item { Id = 1, Name = request.Name });
    }
}