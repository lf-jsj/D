namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;
public class AvatarCodexExcelConfigData : DataObject
{
    [JsonPropertyName("sortId")]
    public int SortId { get; set; }

    [JsonPropertyName("sortFactor")]
    public int SortFactor { get; set; }

    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("beginTime")]
    [JsonConverter(typeof(ParsedDateTimeConverter))]
    public DateTime BeginTime { get; set; }

    [JsonPropertyName("IMPOGOCCALB")]
    public bool? LJECMAJLPIG { get; set; }
}