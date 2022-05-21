namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dungeon;

public class DungeonEntryExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("dungeonEntryId")]
    public int DungeonEntryId { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("isShowInAdvHandbook")]
    public bool IsShowInAdvHandbook { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("cooldownTipsDungeonId")]
    public IList<int> CooldownTipsDungeonId { get; set; } = default!;

    [JsonPropertyName("condComb")]
    public string CondComb { get; set; } = default!;

    [JsonPropertyName("satisfiedCond")]
    public IList<TypeParam1> SatisfiedCond { get; set; } = default!;

    [JsonPropertyName("picPath")]
    public string PicPath { get; set; } = default!;

    [JsonPropertyName("systemOpenUiId")]
    public int SystemOpenUiId { get; set; }

    [JsonPropertyName("rewardDataId")]
    public int RewardDataId { get; set; }

    [JsonPropertyName("descriptionCycleRewardList")]
    public IList<IList<int>> DescriptionCycleRewardList { get; set; } = default!;

    [JsonPropertyName("isDailyRefresh")]
    public bool? IsDailyRefresh { get; set; }

    [JsonPropertyName("isDefaultOpen")]
    public bool? IsDefaultOpen { get; set; }
}
