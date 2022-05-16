namespace Snap.Data.Mapper.Model.ExcelBinOutput.Daily;

public class DailyTaskExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("poolId")]
    public int PoolId { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("rarity")]
    public int Rarity { get; set; }

    [JsonPropertyName("oldGroupVec")]
    public IList<int> OldGroupVec { get; set; } = default!;

    [JsonPropertyName("newGroupVec")]
    public IList<int> NewGroupVec { get; set; } = default!;

    [JsonPropertyName("finishType")]
    public string FinishType { get; set; } = default!;

    [JsonPropertyName("finishProgress")]
    public int FinishProgress { get; set; }

    [JsonPropertyName("taskRewardId")]
    public int TaskRewardId { get; set; }

    [JsonPropertyName("centerPosition")]
    public string CenterPosition { get; set; } = default!;

    [JsonPropertyName("enterDistance")]
    public int EnterDistance { get; set; }

    [JsonPropertyName("exitDistance")]
    public int ExitDistance { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descriptionTextMapHash")]
    public Text DescriptionTextMapHash { get; set; }

    [JsonPropertyName("targetTextMapHash")]
    public Text TargetTextMapHash { get; set; }

    [JsonPropertyName("radarRadius")]
    public double RadarRadius { get; set; }

    [JsonPropertyName("finishParam1")]
    public int? FinishParam1 { get; set; }

    [JsonPropertyName("finishParam2")]
    public int? FinishParam2 { get; set; }

    [JsonPropertyName("questId")]
    public int? QuestId { get; set; }
}
