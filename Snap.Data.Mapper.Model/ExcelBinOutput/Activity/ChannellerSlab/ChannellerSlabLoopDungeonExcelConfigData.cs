namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ChannellerSlab;

public class ChannellerSlabLoopDungeonExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("contentTextMapHash")]
    public Text ContentTextMapHash { get; set; }

    [JsonPropertyName("monsterIdVec")]
    public IList<int> MonsterIdVec { get; set; } = default!;

    [JsonPropertyName("limitingConditionVec")]
    public IList<int> LimitingConditionVec { get; set; } = default!;

    [JsonPropertyName("firstPassRewardId")]
    public int FirstPassRewardId { get; set; }
}
