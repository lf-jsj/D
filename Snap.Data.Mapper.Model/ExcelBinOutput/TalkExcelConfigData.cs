using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class TalkExcelConfigData : DataObject
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("beginWay")]
    public string BeginWay { get; set; } = default!;

    [JsonPropertyName("activeMode")]
    public string ActiveMode { get; set; } = default!;

    [JsonPropertyName("beginCond")]
    public IList<TypeParam<string>> BeginCond { get; set; } = default!;

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("nextTalks")]
    public IList<int> NextTalks { get; set; } = default!;

    [JsonPropertyName("initDialog")]
    public long InitDialog { get; set; }

    [JsonPropertyName("nextRandomTalks")]
    public IList<int> NextRandomTalks { get; set; } = default!;

    [JsonPropertyName("npcId")]
    public IList<int> NpcId { get; set; } = default!;

    [JsonPropertyName("participantId")]
    public IList<int> ParticipantId { get; set; } = default!;

    [JsonPropertyName("performCfg")]
    public string PerformCfg { get; set; } = default!;

    [JsonPropertyName("extraLoadMarkId")]
    public IList<int> ExtraLoadMarkId { get; set; } = default!;

    [JsonPropertyName("prePerformCfg")]
    public string PrePerformCfg { get; set; } = default!;

    [JsonPropertyName("talkMarkHideList")]
    public IList<DataObject> TalkMarkHideList { get; set; } = default!;

    [JsonPropertyName("crowdLOD0List")]
    public IList<int> CrowdLOD0List { get; set; } = default!;

    [JsonPropertyName("finishExec")]
    public IList<TypeParam<string>> FinishExec { get; set; } = default!;

    [JsonPropertyName("beginCondComb")]
    public string BeginCondComb { get; set; } = default!;

    [JsonPropertyName("questId")]
    public int? QuestId { get; set; }

    [JsonPropertyName("heroTalk")]
    public string HeroTalk { get; set; } = default!;

    [JsonPropertyName("talkMarkType")]
    public string TalkMarkType { get; set; } = default!;

    [JsonPropertyName("dontBlockDaily")]
    public bool? DontBlockDaily { get; set; }

    [JsonPropertyName("lowPriority")]
    public bool? LowPriority { get; set; }

    [JsonPropertyName("lockGameTime")]
    public bool? LockGameTime { get; set; }

    [JsonPropertyName("showRandomTalkCount")]
    public int? ShowRandomTalkCount { get; set; }

    [JsonPropertyName("stayFreeStyle")]
    public bool? StayFreeStyle { get; set; }

    [JsonPropertyName("loadType")]
    public string LoadType { get; set; } = default!;

    [JsonPropertyName("enableCameraDisplacement")]
    public bool? EnableCameraDisplacement { get; set; }

    [JsonPropertyName("questIdleTalk")]
    public bool? QuestIdleTalk { get; set; }

    [JsonPropertyName("decoratorID")]
    public int? DecoratorID { get; set; }
}