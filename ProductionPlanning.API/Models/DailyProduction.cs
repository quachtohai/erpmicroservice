namespace ProductionPlanning.API.Models
{
    public class DailyProduction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public int TotalQuantity { get; set; } = default!;
        public int NgQuantity1 { get; set; } = default!;
        public int NgQuantity2 { get; set; } = default!;
        public int GoodsQuantity { get; set; } = default!;
        public int QcQuantity { get; set; } = default!;
        public int IncomeQuantity { get; set; } = default!;
        public int ManPower { get; set; } = default!;
        public string? WeldingLine { get; set; } = default!;
        public string? Description { get; set; } = default!;
        public string? Description2 { get; set; } = default!;
        public string? Description3 { get; set; } = default!;
        public string? Description4 { get; set; } = default!;
        public string Type { get; set; } = default!;
        public bool IsActive { get; set; }
    }
}
