using MediatR;
using dot_net_graphql.Models;

namespace dot_net_graphql.Commands;

public record CreateItemCommand(string Name) : IRequest<Item>;