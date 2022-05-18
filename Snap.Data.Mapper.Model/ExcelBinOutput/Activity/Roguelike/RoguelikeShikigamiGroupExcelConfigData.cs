namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Roguelike;

public class RoguelikeShikigamiGroupExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("FAELCGMBLMO")]
    public FAELCGMBLMO FAELCGMBLMO { get; set; } = default!;
}