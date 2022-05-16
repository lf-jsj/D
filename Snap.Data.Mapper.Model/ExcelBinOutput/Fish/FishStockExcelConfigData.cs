namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fish;

public class FishStockExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("fishWeight")]
    public IDictionary<string, int> FishWeight { get; set; } = default!;
}