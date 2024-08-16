using System.ComponentModel.DataAnnotations.Schema;

namespace Item.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Column("ProductCode01")]
        public string? ProductCode01 { get; set; }
        [Column("ProductCode02")]
        public string? ProductCode02 { get; set; }
        public string? ProductName { get; set; } = default!;
        public string? Description { get; set; } = default!;
        public string? Description2 { get; set; } = default!;
        public string? Description3 { get; set; } = default!;
        public string? Description4 { get; set; } = default!;
        public string? Description5 { get; set; } = default!;
        public string? Description6 { get; set; } = default!;
        public string? Process { get; set; } = default!;
        public bool IsActive { get; set; }
    }
}
