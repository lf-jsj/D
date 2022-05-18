namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Roguelike;

public class RogueTokenExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("stageId")]
    public int StageId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("FIMIFAMPHAM")]
    public IList<int> FIMIFAMPHAM { get; set; } = default!;

    [JsonPropertyName("FANIODFFMEL")]
    public IList<int> FANIODFFMEL { get; set; } = default!;

    [JsonPropertyName("PHDAJMGNMJN")]
    public IList<int> PHDAJMGNMJN { get; set; } = default!;

    [JsonPropertyName("KGAHJCDHHHC")]
    public string KGAHJCDHHHC { get; set; } = default!;
}