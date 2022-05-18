namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class OptionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("contentTextMapHash")]
    public Text ContentTextMapHash { get; set; }

    [JsonPropertyName("inteeIconName")]
    public string InteeIconName { get; set; } = default!;

    [JsonPropertyName("gusetInteeButtonShow")]
    public bool? GusetInteeButtonShow { get; set; }

    [JsonPropertyName("cancelOnlineMatch")]
    public bool? CancelOnlineMatch { get; set; }
}