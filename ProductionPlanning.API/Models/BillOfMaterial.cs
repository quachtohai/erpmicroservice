namespace ProductionPlanning.API.Models
{
    public class BillOfMaterial
    {
        public int Id { get; set; }
        public string ProductionCode { get; set; }
        public string ProductName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Type { get; set; } = default!;
        public bool IsActive { get; set; }
    }
}
