namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reputation;

public class ReputationRequestExcelConfigData : DataObject
{
    [JsonPropertyName("RequestId")]
    public int RequestId { get; set; }

    [JsonPropertyName("QuestId")]
    public int QuestId { get; set; }

    [JsonPropertyName("GroupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("npcId")]
    public int NpcId { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("iconName")]
    public string IconName { get; set; } = default!;
}