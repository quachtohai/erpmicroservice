namespace BuildingBlocks.Messaging.Events
{
    public record ProductEvent : IntegrationEvent
    {
        public string? ProductCode01 { get; set; }
        public string? ProductCode02 { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public string? Process { get; set; }
    }
}
