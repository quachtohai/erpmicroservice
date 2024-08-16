using BuildingBlocks.CQRS;
using DictionaryInfo.Grpc;
using FluentValidation;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.UpdateDictionaryInfo
{
    public record DictionaryInfoCommand(DictionaryInfoDto DictionaryInfo)
    : ICommand<DictionaryInfoResult>;
    public record DictionaryInfoResult(bool IsSuccess);

    public class DictionaryInfoCommandValidator
        : AbstractValidator<DictionaryInfoCommand>
    {
        public DictionaryInfoCommandValidator()
        {

        }
    }
    public class UpdateDictionaryInfoHandler
        (DictionaryInfoProtoService.DictionaryInfoProtoServiceClient dictionaryInfoDto)
    : ICommandHandler<DictionaryInfoCommand, DictionaryInfoResult>
    {
        public async Task<DictionaryInfoResult> Handle(DictionaryInfoCommand request, CancellationToken cancellationToken)
        {
            var result = await dictionaryInfoDto.UpdateDictionaryInfoAsync(new DictionaryInfo.Grpc.UpdateDictionaryInfoRequest()
            {
               DictionaryInfo = new DictionaryInfoModel()
                {
                    Id = request.DictionaryInfo.Id,
                    DictionaryInfoCode = request.DictionaryInfo.DictionaryInfoCode,
                    DictionaryInfoName = request.DictionaryInfo.DictionaryInfoName,
                    Description = request.DictionaryInfo.Description,
                    IsActive = true,
                    Description2 = string.Empty,
                    Description3 = string.Empty,
                    Description4 = string.Empty,
                    Description5 = string.Empty,
                    Description6 = string.Empty,
                    Process = request.DictionaryInfo.Process


                }
            }, cancellationToken: cancellationToken);
            return new DictionaryInfoResult(true);
        }


    }
}
