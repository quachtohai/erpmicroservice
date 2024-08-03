using BuildingBlocks.CQRS;
using FluentValidation;
using Mapster;
using Material.Grpc;

namespace ProductionPlanning.API.ProductionPlanning.GetMaterialInfos
{
    public record MaterialCommand(string MaterialCode, string MaterialName, string Description) : ICommand<MaterialResult>;
    public record MaterialResult(string MaterialCode, string MaterialName, string Description);

    public class MaterialCommandValidator : AbstractValidator<MaterialCommand>
    {
        public MaterialCommandValidator()
        {

        }
    }

    public class StoreBasketCommandHandler(
         MaterialProtoService.MaterialProtoServiceClient materialDto)
        : ICommandHandler<MaterialCommand, MaterialResult>
    {
        public async Task<MaterialResult> Handle(MaterialCommand command, CancellationToken cancellationToken)
        {

            var materialInfos = await materialDto.GetMaterialAsync(new GetMaterialRequest() { MateritalName = "Latch" }, cancellationToken: cancellationToken);
            return materialInfos.Adapt<MaterialResult>();

        }


    }
}


