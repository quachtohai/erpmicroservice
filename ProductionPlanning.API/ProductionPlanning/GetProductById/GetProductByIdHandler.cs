using BuildingBlocks.CQRS;
using Product.Grpc;
using ProductionPlanning.API.Dtos;
using ProductionPlanning.API.Extensions;

namespace ProductionPlanning.API.ProductionPlanning.GetProductById
{
    public record GetProductByIdQuery(int ProductId)
   : IQuery<GetProductByIdResult>;

    public record GetProductByIdResult(ProductDto Results);

    public class GetProductQueryHandler(
         ProductProtoService.ProductProtoServiceClient productDto)
        : IQueryHandler<GetProductByIdQuery, GetProductByIdResult>
    {
        public async Task<GetProductByIdResult> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
        {

            var products = await productDto.GetProductByIdAsync(new GetProductRequestById()
            { Id = query.ProductId }, cancellationToken: cancellationToken);
            List<ProductModel> productModels = new List<ProductModel>() { products };


            return new GetProductByIdResult(
                productModels.ToProductDtoList().FirstOrDefault()
              );



        }


    }
}
