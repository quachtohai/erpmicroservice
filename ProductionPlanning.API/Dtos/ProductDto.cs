namespace ProductionPlanning.API.Dtos
{

    public record ProductDto(
      int Id, string? ProductCode01, string? ProductCode02,
      string? ProductName, string Description, string? Process
      );
}
