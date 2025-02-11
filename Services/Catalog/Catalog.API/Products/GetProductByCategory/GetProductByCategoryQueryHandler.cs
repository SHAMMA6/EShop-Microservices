namespace Catalog.API.Products.GetProductByCategory
{

    public record GetProductByCategoryQuery(string category) : IQuery<GetProductByCategoryResult>;

    public record GetProductByCategoryResult(IEnumerable<Product> Products);


    internal class GetProductByCategoryQueryHandler
        (IDocumentSession session) 
        : IQueryHandler<GetProductByCategoryQuery, GetProductByCategoryResult>
    {
        public async Task<GetProductByCategoryResult> Handle(GetProductByCategoryQuery query, CancellationToken cancellationToken)
        {
            var products = await session.Query<Product>().Where(p => p.Category.Contains(query.category)).ToListAsync();

            return new GetProductByCategoryResult(products);
        }   
    }
}
