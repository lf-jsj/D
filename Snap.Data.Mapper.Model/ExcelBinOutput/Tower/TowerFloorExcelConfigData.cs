namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tower;

public class TowerFloorExcelConfigData : DataObject
{
    [JsonPropertyName("floorId")]
    public int FloorId { get; set; }

    [JsonPropertyName("floorIndex")]
    public int FloorIndex { get; set; }

    [JsonPropertyName("levelGroupId")]
    public int LevelGroupId { get; set; }

    [JsonPropertyName("overrideMonsterLevel")]
    public int OverrideMonsterLevel { get; set; }

    [JsonPropertyName("teamNum")]
    public int TeamNum { get; set; }

    [JsonPropertyName("rewardIdFiveStars")]
    public int RewardIdFiveStars { get; set; }

    [JsonPropertyName("rewardIdTenStars")]
    public int RewardIdTenStars { get; set; }

    [JsonPropertyName("rewardIdFifteenStars")]
    public int RewardIdFifteenStars { get; set; }

    [JsonPropertyName("rewardIdThreeStars")]
    public int RewardIdThreeStars { get; set; }

    [JsonPropertyName("rewardIdSixStars")]
    public int RewardIdSixStars { get; set; }

    [JsonPropertyName("rewardIdNineStars")]
    public int RewardIdNineStars { get; set; }

    [JsonPropertyName("unlockStarCount")]
    public int UnlockStarCount { get; set; }

    [JsonPropertyName("floorLevelConfigId")]
    public int FloorLevelConfigId { get; set; }

    [JsonPropertyName("bgImage")]
    public string BgImage { get; set; } = default!;
}