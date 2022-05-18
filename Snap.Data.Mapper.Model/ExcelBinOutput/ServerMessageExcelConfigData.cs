namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ServerMessageExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("contentTextMapHash")]
    public Text ContentTextMapHash { get; set; }

    [JsonPropertyName("showType")]
    public string ShowType { get; set; } = default!;
}