namespace Item.API.Models
{
    public class DictionaryInfo
    {
        public int Id { get; set; }
        public string? DictionaryInfoCode { get; set; }
       
        public string? DictionaryInfoName { get; set; } = default!;
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
