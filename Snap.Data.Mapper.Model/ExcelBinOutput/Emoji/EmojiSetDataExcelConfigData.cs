namespace Snap.Data.Mapper.Model.ExcelBinOutput.Emoji;

public class EmojiSetDataExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;
}