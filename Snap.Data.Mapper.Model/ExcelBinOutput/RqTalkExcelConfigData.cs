using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class RqTalkExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("beginWay")]
    public string BeginWay { get; set; } = default!;

    [JsonPropertyName("beginCond")]
    public IList<TypeParam<int>> BeginCond { get; set; } = default!;

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("nextTalks")]
    public IList<int> NextTalks { get; set; } = default!;

    [JsonPropertyName("nextRandomTalks")]
    public IList<int> NextRandomTalks { get; set; } = default!;

    [JsonPropertyName("initDialog")]
    public int InitDialog { get; set; }

    [JsonPropertyName("npcId")]
    public IList<int> NpcId { get; set; } = default!;

    [JsonPropertyName("performCfg")]
    public string PerformCfg { get; set; } = default!;

    [JsonPropertyName("questId")]
    public int QuestId { get; set; }

    [JsonPropertyName("beginCondComb")]
    public string BeginCondComb { get; set; } = default!;

    [JsonPropertyName("heroTalk")]
    public string HeroTalk { get; set; } = default!;

    [JsonPropertyName("showRandomTalkCount")]
    public int? ShowRandomTalkCount { get; set; }
}