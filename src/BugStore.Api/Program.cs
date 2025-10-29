using BugStore.Api.Controllers;
using BugStore.Application;
using BugStore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDependencies();
builder.Services.AddInfrastructureDependencies();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapCustomersEndpoints();
app.MapProductsEndpoints();
app.MapOrdersEndpoints();
app.MapReportsEndpoints();

app.Run();
