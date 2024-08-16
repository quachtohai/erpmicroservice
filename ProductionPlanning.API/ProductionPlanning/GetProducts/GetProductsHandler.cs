using BuildingBlocks.CQRS;
using BuildingBlocks.Pagination;
using Product.Grpc;
using ProductionPlanning.API.Dtos;
using ProductionPlanning.API.Extensions;

namespace ProductionPlanning.API.ProductionPlanning.GetProducts
{
    public record GetProductsQuery(PaginationRequest PaginationRequest)
     : IQuery<GetProductsResult>;

    public record GetProductsResult(PaginatedResult<ProductDto> Results);

    public class GetProductQueryHandler(
         ProductProtoService.ProductProtoServiceClient productDto)
        : IQueryHandler<GetProductsQuery, GetProductsResult>
    {
        public async Task<GetProductsResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
        {

            var products = await productDto.GetProductAsync(new GetProductRequest()
            { }, cancellationToken: cancellationToken);

            var pageIndex = query.PaginationRequest.PageIndex;
            var pageSize = query.PaginationRequest.PageSize;

            var totalCount = products.Product.ToList().Count;

            return new GetProductsResult(
               new PaginatedResult<ProductDto>(
                   pageIndex,
                   pageSize,
                   totalCount,
                   products.Product.ToList().ToProductDtoList()));



        }


    }
}
