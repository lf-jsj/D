using Snap.Data.Mapper.Model.Common.Param;
using System.Text.Json;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Quest;

public class QuestExcelConfigData : DataObject
{
    [JsonPropertyName("subId")]
    public int SubId { get; set; }

    [JsonPropertyName("mainId")]
    public int MainId { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("stepDescTextMapHash")]
    public Text StepDescTextMapHash { get; set; }

    [JsonPropertyName("guideTipsTextMapHash")]
    public Text GuideTipsTextMapHash { get; set; }

    [JsonPropertyName("showType")]
    public string ShowType { get; set; } = default!;

    [JsonPropertyName("acceptCond")]
    public IList<TypeParam<int>> AcceptCond { get; set; } = default!;

    [JsonPropertyName("finishCond")]
    public IList<TypeParamParamStrCount<int>> FinishCond { get; set; } = default!;

    [JsonPropertyName("failCond")]
    public IList<TypeParamParamStrCount<int>> FailCond { get; set; } = default!;

    [JsonPropertyName("guide")]
    public Guide Guide { get; set; } = default!;

    [JsonPropertyName("finishExec")]
    public IList<TypeParam<string>> FinishExec { get; set; } = default!;

    [JsonPropertyName("failExec")]
    public IList<TypeParam<string>> FailExec { get; set; } = default!;

    [JsonPropertyName("beginExec")]
    public IList<TypeParam<string>> BeginExec { get; set; } = default!;

    [JsonPropertyName("exclusiveNpcList")]
    public IList<int> ExclusiveNpcList { get; set; } = default!;

    [JsonPropertyName("sharedNpcList")]
    public IList<int> SharedNpcList { get; set; } = default!;

    [JsonPropertyName("trialAvatarList")]
    public IList<int> TrialAvatarList { get; set; } = default!;

    [JsonPropertyName("exclusivePlaceList")]
    public IList<int> ExclusivePlaceList { get; set; } = default!;

    [JsonPropertyName("finishCondComb")]
    public JsonElement FinishCondComb { get; set; } = default!;

    [JsonPropertyName("finishParent")]
    public bool? FinishParent { get; set; }

    [JsonPropertyName("showGuide")]
    public string ShowGuide { get; set; } = default!;

    [JsonPropertyName("isRewind")]
    public bool? IsRewind { get; set; }

    [JsonPropertyName("acceptCondComb")]
    public string AcceptCondComb { get; set; } = default!;

    [JsonPropertyName("failCondComb")]
    public string FailCondComb { get; set; } = default!;

    [JsonPropertyName("banType")]
    public string BanType { get; set; } = default!;

    [JsonPropertyName("exclusiveNpcPriority")]
    public int? ExclusiveNpcPriority { get; set; }

    [JsonPropertyName("isMpBlock")]
    public bool? IsMpBlock { get; set; }

    [JsonPropertyName("subIdSet")]
    public int? SubIdSet { get; set; }

    [JsonPropertyName("failParent")]
    public bool? FailParent { get; set; }
}