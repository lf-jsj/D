namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class LandSoundExcelConfigData : DataObject
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("audioName")]
    public string AudioName { get; set; } = default!;

    [JsonPropertyName("id")]
    public int? Id { get; set; }
}
