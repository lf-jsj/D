namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class TauntLevelTemplateExcelConfigData : DataObject
{
    [JsonPropertyName("tauntLevelVal")]
    public int TauntLevelVal { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
}