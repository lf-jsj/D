namespace Snap.Data.Mapper.Model.ExcelBinOutput.Guide;
public class GuideRatingExcelConfigData : DataObject
{
    [JsonPropertyName("channelID")]
    public int ChannelID { get; set; }

    [JsonPropertyName("isChinaServer")]
    public bool IsChinaServer { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; } = default!;

    [JsonPropertyName("platform")]
    public string Platform { get; set; } = default!;

    [JsonPropertyName("subChannelId")]
    public int? SubChannelId { get; set; }
}