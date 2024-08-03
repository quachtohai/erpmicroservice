using BuildingBlocks.Messaging.Events;
using MassTransit;
using MediatR;
using Microsoft.AspNetCore.Hosting.Server;

namespace Item.API.Events.Intergration
{
    public class InsertMaterialInfoHandler
         (ISender sender, ILogger<InsertMaterialInfoHandler> logger)
    : IConsumer<MaterialInfoEvent>
    {
        public async Task Consume(ConsumeContext<MaterialInfoEvent> context)
        {
            logger.LogInformation("Integration Event handled: {IntegrationEvent}", context.Message.GetType().Name);
           
        }
    }
}
