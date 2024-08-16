using Product.Grpc;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.Extensions
{
    public static class ProductExtensions
    {
        public static IEnumerable<ProductDto> ToProductDtoList(this IEnumerable<ProductModel> products)
        {
            return products.Select(product => new ProductDto(
              Id: product.Id,
              ProductCode01: product.ProductCode01,
              ProductCode02: product.ProductCode02,
              ProductName: product.ProductName,
              Description: product.Description,
              Process: product.Process
            ));
        }
    }
}
