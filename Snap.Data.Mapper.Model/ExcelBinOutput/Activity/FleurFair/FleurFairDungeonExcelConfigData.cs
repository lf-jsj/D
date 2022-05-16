namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.FleurFair;

public class FleurFairDungeonExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("sectionId")]
    public int SectionId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("obtainCoinLimit")]
    public int ObtainCoinLimit { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("miniGameList")]
    public IList<int> MiniGameList { get; set; } = default!;

    [JsonPropertyName("monsterList")]
    public IList<int> MonsterList { get; set; } = default!;

    [JsonPropertyName("energyGradeList")]
    public IList<int> EnergyGradeList { get; set; } = default!;

    [JsonPropertyName("initialEnergy")]
    public int InitialEnergy { get; set; }

    [JsonPropertyName("energyLimit")]
    public int EnergyLimit { get; set; }

    [JsonPropertyName("successRewardId")]
    public int SuccessRewardId { get; set; }

    [JsonPropertyName("failureRewardId")]
    public int FailureRewardId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }
}
