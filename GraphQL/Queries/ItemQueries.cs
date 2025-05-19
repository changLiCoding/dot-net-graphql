using MediatR;
using HotChocolate;
using dot_net_graphql.Models;
using dot_net_graphql.Queries;

namespace dot_net_graphql.GraphQL.Queries;

public class ItemQueries
{
    public async Task<Item> GetItem(int id, [Service] IMediator mediator)
        => await mediator.Send(new GetItemQuery(id));
}