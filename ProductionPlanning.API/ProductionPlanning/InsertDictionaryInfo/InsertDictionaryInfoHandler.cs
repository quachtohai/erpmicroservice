using BuildingBlocks.CQRS;
using BuildingBlocks.Messaging.Events;
using DictionaryInfo.Grpc;
using FluentValidation;
using Mapster;
using MassTransit;
using ProductionPlanning.API.Dtos;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProductionPlanning.API.ProductionPlanning.InsertDictionaryInfo
{
    public record DictionaryInfoCommand(DictionaryInfoDto DictionaryInfo)
    : ICommand<DictionaryInfoResult>;
    public record DictionaryInfoResult(int Id);

    public class DictionaryInfoCommandValidator
        : AbstractValidator<DictionaryInfoCommand>
    {
        public DictionaryInfoCommandValidator()
        {

        }
    }
    public class InsertDictionaryInfoHandler
        (DictionaryInfoProtoService.DictionaryInfoProtoServiceClient dictionaryInfoDto)
    : ICommandHandler<DictionaryInfoCommand, DictionaryInfoResult>
    {
        public async Task<DictionaryInfoResult> Handle(DictionaryInfoCommand request, CancellationToken cancellationToken)
        {
            var result = await dictionaryInfoDto.CreateDictionaryInfoAsync(new CreateDictionaryInfoRequest()
            {
                DictionaryInfo = new DictionaryInfoModel()
                {
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
            return new DictionaryInfoResult(result.Id);
        }
    }
}
