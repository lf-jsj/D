namespace Snap.Data.Mapper.Model.ExcelBinOutput.Routine;

public class RoutineDetailExcelConfigData : DataObject
{
    [JsonPropertyName("routineId")]
    public int RoutineId { get; set; }

    [JsonPropertyName("routineType")]
    public string RoutineType { get; set; } = default!;

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("isBackup")]
    public bool IsBackup { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("finishContent")]
    public FinishContent FinishContent { get; set; } = default!;

    [JsonPropertyName("goodsIdVec")]
    public IList<GoodsIdVec> GoodsIdVec { get; set; } = default!;

    [JsonPropertyName("FJFOAPDLHDF")]
    public IList<FJFOAPDLHDF> FJFOAPDLHDF { get; set; } = default!;

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("goalTextMapHash")]
    public Text GoalTextMapHash { get; set; }

    [JsonPropertyName("centerPosition")]
    public string CenterPosition { get; set; } = default!;

    [JsonPropertyName("radarRadius")]
    public int RadarRadius { get; set; }

    [JsonPropertyName("enterDistance")]
    public int EnterDistance { get; set; }

    [JsonPropertyName("exitDistance")]
    public int ExitDistance { get; set; }

    [JsonPropertyName("tag")]
    public int? Tag { get; set; }
}
