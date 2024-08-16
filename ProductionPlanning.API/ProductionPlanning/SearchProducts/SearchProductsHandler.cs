using BuildingBlocks.CQRS;
using BuildingBlocks.Search;
using Product.Grpc;
using ProductionPlanning.API.Dtos;
using ProductionPlanning.API.Extensions;

namespace ProductionPlanning.API.ProductionPlanning.SearchProducts
{
    public record SearchProductsQuery(SearchRequest Param)
          : IQuery<SearchProductsResult>;

    public record SearchProductsResult(SearchResult<ProductDto> Results);

    public class SearchUserInfosHandler(ProductProtoService.ProductProtoServiceClient productDto)
     : IQueryHandler<SearchProductsQuery, SearchProductsResult>
    {
        public async Task<SearchProductsResult> Handle(SearchProductsQuery query, CancellationToken cancellationToken)
        {

            var q = query.Param.Q;
            var fields = query.Param.Fields;

            var products = await productDto.GetProductAsync(new GetProductRequest()
            { ProductName =q }, cancellationToken: cancellationToken);

            //await dbContext.UserInfos.ForEachAsync(info => {
            //    if (q.Equals(string.Empty) || info.GetType().GetProperty(fields).GetValue(info, null).ToString().Contains(q.ToString()))
            //        userInfos.Add(info);
            //});


            return new SearchProductsResult(
                new SearchResult<ProductDto>(
                    true, "Search Products successfully ",
                   products.Product.ToList().ToProductDtoList()));
        }
    }
}
