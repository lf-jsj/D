namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class CutsceneExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; } = default!;
}
