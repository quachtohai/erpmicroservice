using BuildingBlocks.CQRS;
using BuildingBlocks.Messaging.Events;
using FluentValidation;
using Mapster;
using MassTransit;
using ProductionPlanning.API.Dtos;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProductionPlanning.API.ProductionPlanning.InsertMaterialInfo
{
    public record MaterialInfoCommand(MaterialInfoDto MaterialInfoDto)
    : ICommand<MaterialInfoResult>;
    public record MaterialInfoResult(bool IsSuccess);

    public class MaterialInfoCommandValidator
        : AbstractValidator<MaterialInfoCommand>
    {
        public MaterialInfoCommandValidator()
        {

        }
    }
    public class InsertMaterialInfoHandler
        (IPublishEndpoint publishEndpoint)
    : ICommandHandler<MaterialInfoCommand, MaterialInfoResult>
    {
        public async Task<MaterialInfoResult> Handle(MaterialInfoCommand request, CancellationToken cancellationToken)
        {
            var eventMessage = request.MaterialInfoDto.Adapt<MaterialInfoEvent>();
           
            await publishEndpoint.Publish(eventMessage, cancellationToken);           

            return new MaterialInfoResult(true);
        }
    }
}
