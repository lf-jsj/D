namespace Snap.Data.Mapper.Model.ExcelBinOutput.Emoji;
public class EmojiDataExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("setID")]
    public int SetID { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("contentTextMapHash")]
    public Text ContentTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;
}
