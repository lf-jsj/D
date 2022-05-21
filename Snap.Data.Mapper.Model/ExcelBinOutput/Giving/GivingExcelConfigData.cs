using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Giving;

public class GivingExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("talkId")]
    public int TalkId { get; set; }

    [JsonPropertyName("mistakeTalkId")]
    public int MistakeTalkId { get; set; }

    [JsonPropertyName("tab")]
    public string Tab { get; set; } = default!;

    [JsonPropertyName("givingMethod")]
    public string GivingMethod { get; set; } = default!;

    [JsonPropertyName("exactItems")]
    public IList<IdCount<int>> ExactItems { get; set; } = default!;

    [JsonPropertyName("exactFinishTalkId")]
    public int ExactFinishTalkId { get; set; }

    [JsonPropertyName("givingGroupIds")]
    public IList<int> GivingGroupIds { get; set; } = default!;

    [JsonPropertyName("highlight")]
    public bool Highlight { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("isRemoveItem")]
    public bool IsRemoveItem { get; set; }

    [JsonPropertyName("isRepeatable")]
    public bool? IsRepeatable { get; set; }

    [JsonPropertyName("givingGroupCount")]
    public int? GivingGroupCount { get; set; }

    [JsonPropertyName("EGMINOAJKGK")]
    public bool? EGMINOAJKGK { get; set; }

    [JsonPropertyName("NAOOAMFFEFJ")]
    public bool? NAOOAMFFEFJ { get; set; }
}
