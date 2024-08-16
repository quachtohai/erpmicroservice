using BuildingBlocks.CQRS;
using FluentValidation;
using ProductionPlanning.API.Data;
using ProductionPlanning.API.Dtos;

namespace ProductionPlanning.API.ProductionPlanning.UpdateDailyProduct
{
    public record UpdateDailyProductionCommand(DailyProductionDto DailyProduction)
     : ICommand<UpdateDailyProductionResult>;
    public record UpdateDailyProductionResult(bool IsSuccess);

    public class UpdateDailyProductionCommandValidator : AbstractValidator<UpdateDailyProductionCommand>
    {
        public UpdateDailyProductionCommandValidator()
        {
        }
    }

    public class UpdateDailyProducionHandler(ProductionPlanningContext dbContext)
     : ICommandHandler<UpdateDailyProductionCommand, UpdateDailyProductionResult>
    {
        public async Task<UpdateDailyProductionResult> Handle(UpdateDailyProductionCommand command, CancellationToken cancellationToken)
        {
            var dailyProduction = await dbContext.DailyProductions
                .FindAsync([command.DailyProduction.Id], cancellationToken: cancellationToken);

            dailyProduction.Date = command.DailyProduction.Date;
            dailyProduction.ProductId = command.DailyProduction.ProductId;
            dailyProduction.ProductName = command.DailyProduction.ProductName;
            dailyProduction.TotalQuantity = command.DailyProduction.TotalQuantity;
            dailyProduction.NgQuantity1 = command.DailyProduction.NgQuantity1;
            dailyProduction.NgQuantity2 = command.DailyProduction.NgQuantity2;
            dailyProduction.GoodsQuantity = command.DailyProduction.GoodsQuantity;
            dailyProduction.QcQuantity = command.DailyProduction.QcQuantity;
            dailyProduction.IncomeQuantity = command.DailyProduction.IncomeQuantity;
            dailyProduction.ManPower = command.DailyProduction.ManPower;
            dailyProduction.WeldingLine = command.DailyProduction.WeldingLine;
            dailyProduction.Description = command.DailyProduction.Description;


            dbContext.DailyProductions.Update(dailyProduction);

            await dbContext.SaveChangesAsync(cancellationToken);

            return new UpdateDailyProductionResult(true);
        }






    }
}
