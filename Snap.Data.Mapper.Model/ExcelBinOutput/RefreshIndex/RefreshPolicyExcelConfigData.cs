namespace Snap.Data.Mapper.Model.ExcelBinOutput.RefreshIndex;

public class RefreshPolicyExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("time")]
    public string Time { get; set; } = default!;
}