using BuildingBlocks.CQRS;
using BuildingBlocks.Pagination;
using DictionaryInfo.Grpc;
using ProductionPlanning.API.Dtos;
using ProductionPlanning.API.Extensions;

namespace ProductionPlanning.API.ProductionPlanning.GetDictionaryInfos
{
    public record GetDictionaryInfosQuery(PaginationRequest PaginationRequest)
   : IQuery<GetDictionaryInfosResult>;

    public record GetDictionaryInfosResult(PaginatedResult<DictionaryInfoDto> Results);

    

    public class GetDictionaryInfoQueryHandler(
         DictionaryInfoProtoService.DictionaryInfoProtoServiceClient dictionaryInfoDto)
        : IQueryHandler<GetDictionaryInfosQuery, GetDictionaryInfosResult>
    {
        public async Task<GetDictionaryInfosResult> Handle(GetDictionaryInfosQuery query, CancellationToken cancellationToken)
        {

            var dictionaryInfos = await dictionaryInfoDto.GetDictionaryInfoAsync(new GetDictionaryInfoRequest()
            { }, cancellationToken: cancellationToken);
            
            var pageIndex = query.PaginationRequest.PageIndex;
            var pageSize = query.PaginationRequest.PageSize;

            var totalCount = dictionaryInfos.Dictionaryinfo.ToList().Count;

            return new GetDictionaryInfosResult(
               new PaginatedResult<DictionaryInfoDto>(
                   pageIndex,
                   pageSize,
                   totalCount,
                   dictionaryInfos.Dictionaryinfo.ToList().ToDictionaryInfoDtoList()));

           

        }


    }
}
