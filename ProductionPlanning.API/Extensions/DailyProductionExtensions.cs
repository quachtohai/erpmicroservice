using ProductionPlanning.API.Dtos;
using ProductionPlanning.API.Models;

namespace ProductionPlanning.API.Extensions
{
    public static class DailyProductionExtensions
    {

        public static IEnumerable<DailyProductionDto> ToDailyProductionDtoList(this IEnumerable<DailyProduction> dailyProductions)
        {
            return dailyProductions.Select(dailyproduction => new DailyProductionDto(
               Id: dailyproduction.Id,
               Date: dailyproduction.Date,
               ProductId: dailyproduction.ProductId,
               ProductName: dailyproduction.ProductName,
               TotalQuantity: dailyproduction.TotalQuantity,
               NgQuantity1: dailyproduction.NgQuantity1,
               NgQuantity2: dailyproduction.NgQuantity2,
               GoodsQuantity: dailyproduction.GoodsQuantity,
               QcQuantity: dailyproduction.QcQuantity,
               IncomeQuantity: dailyproduction.IncomeQuantity,
               ManPower: dailyproduction.ManPower,
               WeldingLine: dailyproduction.WeldingLine,
               Description: dailyproduction.Description,
               Type: dailyproduction.Type,
               Active: true
            )
            {

            });
        }
    }

}
