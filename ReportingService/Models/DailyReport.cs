namespace ReportingService.Models
{
    public class DailyReport
    {
        public DateTime Date { set; get; }
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        public int TotalQuantity { get; set; }
        public int NgQuantity1 { get; set; }
        public int NgQuantity2 { get; set; }
        public int GoodsQuantity { get; set; }
        public int QcQuantity { get; set; }
        public int IncomeQuantity { set; get; }
        public int ManPower { set; get; }
        public string? WeldingLine { get; set; }
        public string? Description { get; set; }
        public string? Description2 { set; get; }
        public string? Description3 { set; get; }
        public string? Type { set; get; }
        public string? ProductCode01 { set; get; }
        public string? ProductCode02
        {
            set; get;

        }
    }
}
