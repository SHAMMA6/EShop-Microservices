
namespace Catalog.API.Products.DeleteProduct
{

    //public record DeleteProductRequest(Guid id)

    public record DeleteProductResponse(bool IsSuccess);
    public class DeleteProductEndpiont : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/products/{id}", async (Guid id, ISender sender) =>
            {
                var result = await sender.Send(new DeleteProductCommand(id));

                var response = result.Adapt<DeleteProductResponse>();

                return Results.Ok(response);

            }).WithName("DeleteProduct")
              .Produces<DeleteProductResponse>(StatusCodes.Status200OK)
              .ProducesProblem(StatusCodes.Status404NotFound)
              .ProducesProblem(StatusCodes.Status400BadRequest)
              .WithSummary("Deletes a product")
              .WithDescription("Deletes a product from the catalog");
        }
    }
}
