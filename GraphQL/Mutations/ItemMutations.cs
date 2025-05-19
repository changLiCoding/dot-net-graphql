using MediatR;
using HotChocolate;
using dot_net_graphql.Models;
using dot_net_graphql.Commands;

namespace dot_net_graphql.GraphQL.Mutations;

public class ItemMutations
{
    public async Task<Item> CreateItem(string name, [Service] IMediator mediator)
        => await mediator.Send(new CreateItemCommand(name));
}