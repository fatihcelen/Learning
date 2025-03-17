using IdentityServer4.Models;
using IdentityServer4.Test;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityServer()
    .AddInMemoryClients(new List<Client>())
    .AddInMemoryApiScopes(new List<ApiScope>())
    .AddInMemoryIdentityResources(new List<IdentityResource>())
    .AddInMemoryApiResources(new List<ApiResource>())
    .AddTestUsers(new List<TestUser>())
    .AddDeveloperSigningCredential();;

var app = builder.Build();

app.UseIdentityServer();

//app.MapGet("/", () => "Hello World!");

app.Run();