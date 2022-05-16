namespace Snap.Data.Mapper.Model.ExcelBinOutput.Giving;

public class GivingGroupExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("ItemIds")]
    public IList<int> ItemIds { get; set; } = default!;

    [JsonPropertyName("finishTalkId")]
    public int FinishTalkId { get; set; }

    [JsonPropertyName("mistakeTalkId")]
    public int MistakeTalkId { get; set; }

    [JsonPropertyName("OHMKPCKFNJL")]
    public int? OHMKPCKFNJL { get; set; }
}