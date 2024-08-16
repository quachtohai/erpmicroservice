using BuildingBlocks.CQRS;
using Carter;
using DictionaryInfo.Grpc;
using MediatR;
using ProductionPlanning.API.Dtos;
using ProductionPlanning.API.Extensions;

namespace ProductionPlanning.API.ProductionPlanning.GetDictionaryInfoById
{
    public record GetDictionaryInfoByIdQuery(int DictionaryInfoId)
   : IQuery<GetDictionaryInfoByIdResult>;

    public record GetDictionaryInfoByIdResult(DictionaryInfoDto Results);

    public class GetDictionaryInfoQueryHandler(
         DictionaryInfoProtoService.DictionaryInfoProtoServiceClient dictionaryInfoDto)
        : IQueryHandler<GetDictionaryInfoByIdQuery, GetDictionaryInfoByIdResult>
    {
        public async Task<GetDictionaryInfoByIdResult> Handle(GetDictionaryInfoByIdQuery query, CancellationToken cancellationToken)
        {

            var dictionaryInfos = await dictionaryInfoDto.GetDictionaryInfoByIdAsync(new GetDictionaryInfoRequestById()
            {Id =query.DictionaryInfoId}, cancellationToken: cancellationToken);
            List<DictionaryInfoModel> dictionaryInfoModels = new List<DictionaryInfoModel>() { dictionaryInfos };


            return new GetDictionaryInfoByIdResult(
                dictionaryInfoModels.ToDictionaryInfoDtoList().FirstOrDefault()
              );



        }


    }
}
