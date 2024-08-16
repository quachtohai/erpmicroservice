using BuildingBlocks.CQRS;
using FluentValidation;
using ProductionPlanning.API.Data;

namespace ProductionPlanning.API.ProductionPlanning.DeleteDailyProduction
{
    public record DeleteDailyProductionCommand(int DailyProductionId)
     : ICommand<DeleteDailyProductionResult>;

    public record DeleteDailyProductionResult(bool IsSuccess);

    public class DeleteDailyProductionCommandValidator : AbstractValidator<DeleteDailyProductionCommand>
    {
        public DeleteDailyProductionCommandValidator()
        {

        }
    }
    public class DeleteDailyProductionHandler(ProductionPlanningContext dbContext)
      : ICommandHandler<DeleteDailyProductionCommand, DeleteDailyProductionResult>
    {
        public async Task<DeleteDailyProductionResult> Handle(DeleteDailyProductionCommand command, CancellationToken cancellationToken)
        {


            var dailyProduction = await dbContext.DailyProductions
                .FindAsync([command.DailyProductionId], cancellationToken: cancellationToken);




            dbContext.DailyProductions.Remove(dailyProduction);
            await dbContext.SaveChangesAsync(cancellationToken);

            return new DeleteDailyProductionResult(true);
        }
    }
}
