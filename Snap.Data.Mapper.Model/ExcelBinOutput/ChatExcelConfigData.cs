namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ChatExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("priority")]
    public float Priority { get; set; }

    [JsonPropertyName("tabShownNameTextMapHash")]
    public Text TabShownNameTextMapHash { get; set; }

    [JsonPropertyName("chatChannelIcon")]
    public string ChatChannelIcon { get; set; } = default!;

    [JsonPropertyName("TagOtherTextMapHash")]
    public Text TagOtherTextMapHash { get; set; }

    [JsonPropertyName("TagSelfTextMapHash")]
    public Text TagSelfTextMapHash { get; set; }

    [JsonPropertyName("EnterTextMapHash")]
    public Text EnterTextMapHash { get; set; }

    [JsonPropertyName("LeaveTextMapHash")]
    public Text LeaveTextMapHash { get; set; }

    [JsonPropertyName("channel")]
    public int? Channel { get; set; }
}
