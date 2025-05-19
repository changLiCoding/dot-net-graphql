using dot_net_graphql.GraphQL.Queries;
using dot_net_graphql.GraphQL.Mutations;

var builder = WebApplication.CreateBuilder(args);

// 配置端口
builder.WebHost.UseUrls("http://localhost:5286");

// 修正 MediatR 配置
builder.Services.AddMediatR(cfg => {
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

builder.Services
    .AddGraphQLServer()
    .AddQueryType<ItemQueries>()
    .AddMutationType<ItemMutations>();

var app = builder.Build();

// 配置 GraphQL 端点
app.MapGraphQL("/graphql");

app.MapGet("/", () => "Hello World!");

app.Run();