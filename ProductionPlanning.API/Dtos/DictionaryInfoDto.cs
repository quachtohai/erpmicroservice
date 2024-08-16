namespace ProductionPlanning.API.Dtos
{
    public record DailyProductionDto(
        int Id, DateTime Date, int? ProductId,
        string ProductName,
        int TotalQuantity,
        int NgQuantity1,
        int NgQuantity2,
        int GoodsQuantity,
        int QcQuantity,
        int IncomeQuantity,
        int ManPower,
        string? WeldingLine,
        string? Description,
        string Type,
        bool Active

        );

}
