namespace ProductionPlanning.API.Dtos
{
    public record DictionaryInfoDto(
       int Id, string? DictionaryInfoCode, string? DictionaryInfoName,
       string? Description, string? Process
       );

}
