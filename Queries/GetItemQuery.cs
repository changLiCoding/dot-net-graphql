using MediatR;
using dot_net_graphql.Models;

namespace dot_net_graphql.Queries;

public record GetItemQuery(int Id) : IRequest<Item>;