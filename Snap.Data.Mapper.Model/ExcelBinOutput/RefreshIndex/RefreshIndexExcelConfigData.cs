namespace Snap.Data.Mapper.Model.ExcelBinOutput.RefreshIndex;
public class RefreshIndexExcelConfigData : DataObject
{
    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("refreshId")]
    public int RefreshId { get; set; }

    [JsonPropertyName("rarity")]
    public string Rarity { get; set; } = default!;
}
