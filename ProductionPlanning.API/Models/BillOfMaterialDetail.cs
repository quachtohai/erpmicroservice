namespace ProductionPlanning.API.Models
{
    public class BillOfMaterialDetail
    {
        public int Id { get; set; }
        public int BillOfMaterialId { set;get; }
        public int ItemId { get; set; }
        public string ItemName { get; set; } = default!;
        public decimal Quantity { get; set; } = default!;
        public string Description { get; set; } = default!;
        public bool IsActive { get; set; }
    }
}
