namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BonusActivity;
public class BonusActivityClientExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("bonusActivityType")]
    public string BonusActivityType { get; set; } = default!;

    [JsonPropertyName("avatarConfigId")]
    public int AvatarConfigId { get; set; }

    [JsonPropertyName("voiceIndexList")]
    public IList<int> VoiceIndexList { get; set; } = default!;

    [JsonPropertyName("openPlayerLevel")]
    public int OpenPlayerLevel { get; set; }

    [JsonPropertyName("perfabPath")]
    public string PerfabPath { get; set; } = default!;

    [JsonPropertyName("unlockTipsTextMapHash")]
    public Text UnlockTipsTextMapHash { get; set; }

    [JsonPropertyName("questId")]
    public int? QuestId { get; set; }
}
