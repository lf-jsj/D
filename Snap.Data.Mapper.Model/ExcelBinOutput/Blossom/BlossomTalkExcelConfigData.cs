namespace Snap.Data.Mapper.Model.ExcelBinOutput.Blossom;

public class BlossomTalkExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("refreshId")]
    public int RefreshId { get; set; }

    [JsonPropertyName("talkId")]
    public IList<int> TalkId { get; set; } = default!;

    [JsonPropertyName("groupId")]
    public int? GroupId { get; set; }
}