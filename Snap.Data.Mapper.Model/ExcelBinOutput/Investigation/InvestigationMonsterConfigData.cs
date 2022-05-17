namespace Snap.Data.Mapper.Model.ExcelBinOutput.Investigation;

public class InvestigationMonsterConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("monsterIdList")]
    public IList<int> MonsterIdList { get; set; } = default!;

    [JsonPropertyName("groupIdList")]
    public IList<int> GroupIdList { get; set; } = default!;

    [JsonPropertyName("HCCGPPDCBCA")]
    public IList<int> HCCGPPDCBCA { get; set; } = default!;

    [JsonPropertyName("IMCGNPHHCNB")]
    public IList<int> IMCGNPHHCNB { get; set; } = default!;

    [JsonPropertyName("DMBEFANHLMG")]
    public Text DMBEFANHLMG { get; set; }

    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }

    [JsonPropertyName("mapMarkCreateType")]
    public string MapMarkCreateType { get; set; } = default!;

    [JsonPropertyName("mapMarkCreateCondition")]
    public MapMarkCreateCondition MapMarkCreateCondition { get; set; } = default!;

    [JsonPropertyName("monsterCategory")]
    public string MonsterCategory { get; set; } = default!;

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("lockDescTextMapHash")]
    public Text LockDescTextMapHash { get; set; }

    [JsonPropertyName("occupiedQuestIdList")]
    public IList<int> OccupiedQuestIdList { get; set; } = default!;

    [JsonPropertyName("unlockParentQuestId")]
    public int? UnlockParentQuestId { get; set; }
}