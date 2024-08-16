using BuildingBlocks.CQRS;
using FluentValidation;
using MassTransit.NewIdProviders;
using ProductionPlanning.API.Data;
using ProductionPlanning.API.Dtos;
using ProductionPlanning.API.Models;

namespace ProductionPlanning.API.ProductionPlanning.DailyProduct
{
    public record CreateDailyProductionCommand( DailyProductionDto DailyProduction)
     : ICommand<CreateDailyProductionResult>;

    public record CreateDailyProductionResult(int Id);


    public class CreateDailyProductionCommandValidator : AbstractValidator<CreateDailyProductionCommand>
    {
        public CreateDailyProductionCommandValidator()
        {

        }
    }
    public class CreateDailyProductHandler
    {
    }

    public class CreateDailyProductionHandler(ProductionPlanningContext dbContext)
      : ICommandHandler<CreateDailyProductionCommand, CreateDailyProductionResult>
    {
        public async Task<CreateDailyProductionResult> Handle(CreateDailyProductionCommand command, CancellationToken cancellationToken)
        {


            DailyProduction dailyProduction = new DailyProduction()
            {
                 Date = command.DailyProduction.Date,
                 ProductId = command.DailyProduction.ProductId,
                 ProductName = command.DailyProduction.ProductName?? string.Empty,
                 Description = command.DailyProduction.Description,
                 Description2 = "",
                 Description3 ="",
                 Description4 = "",
                 GoodsQuantity = command.DailyProduction.GoodsQuantity,
                 IncomeQuantity = command.DailyProduction.IncomeQuantity,
                 IsActive = true,
                 ManPower = command.DailyProduction.ManPower,
                 NgQuantity1 = command.DailyProduction.NgQuantity1,
                 NgQuantity2 = command.DailyProduction.NgQuantity2,
                 QcQuantity = command.DailyProduction.QcQuantity,
                 TotalQuantity = command.DailyProduction.TotalQuantity,
                 Type = command.DailyProduction.Type,
                 WeldingLine =command.DailyProduction.WeldingLine
            };

            dbContext.DailyProductions.Add(dailyProduction);
            await dbContext.SaveChangesAsync(cancellationToken);

            return new CreateDailyProductionResult(dailyProduction.Id);
        }

        
    }
}
