namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.LunaRite;
public class LunaRiteBattleBuffExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("MPPMJCEHDEO")]
    public string MPPMJCEHDEO { get; set; } = default!;

    [JsonPropertyName("PMIHFKKMOML")]
    public int PMIHFKKMOML { get; set; }

    [JsonPropertyName("LEJBIIOIAEL")]
    public Text LEJBIIOIAEL { get; set; }

    [JsonPropertyName("rewardId")]
    public int? RewardId { get; set; }
}
