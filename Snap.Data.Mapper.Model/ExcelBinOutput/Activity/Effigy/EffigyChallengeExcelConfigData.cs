namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Effigy;
public class EffigyChallengeExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("dayIndex")]
    public int DayIndex { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("prefab")]
    public string Prefab { get; set; } = default!;

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("contentTextMapHash")]
    public Text ContentTextMapHash { get; set; }

    [JsonPropertyName("limitingConditionVec")]
    public IList<int> LimitingConditionVec { get; set; } = default!;

    [JsonPropertyName("upAvatarVec")]
    public IList<int> UpAvatarVec { get; set; } = default!;

    [JsonPropertyName("firstPassRewardId")]
    public int FirstPassRewardId { get; set; }
}
