using BugStore.Application.Products.Requests;
using MediatR;

namespace BugStore.Api.Controllers
{
    public static class ProductsController
    {
        public static void MapProductsEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/v1/products");

            group.MapGet("/", async ([AsParameters] GetProductRequest request, IMediator mediator) =>
            {
                var result = await mediator.Send(request);
                return Results.Ok(result);
            });

            group.MapGet("/{id}", () => "Hello World!");

            group.MapPost("/", async (CreateProductRequest request, IMediator mediator) =>
            {
                var result = await mediator.Send(request);
                return Results.Created($"/v1/products/{result.Id}", result);
            });

            group.MapPut("/{id}", () => "Hello World!");

            group.MapDelete("/{id}", () => "Hello World!");
        }
    }
}
