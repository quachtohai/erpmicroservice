namespace BuildingBlocks.Messaging.Events
{
    public record DictionaryInfoEvent : IntegrationEvent
    {
        public string? DictionaryInfoCode { get; set; }
        public string? DictionaryInfoName { get; set; }
        public string? Description { get; set; }
        public string? Process { get; set; }
    }
}
