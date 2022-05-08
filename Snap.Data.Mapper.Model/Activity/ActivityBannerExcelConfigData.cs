namespace Snap.Data.Mapper.Model.Activity;

public class ActivityBannerExcelConfigData
{
    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    /// <summary>
    /// string.Empty
    /// ACTIVITY_BANNER_MONSTER
    /// </summary>
    [JsonPropertyName("LOHDLJEHAHA")]
    public string LOHDLJEHAHA { get; set; } = string.Empty;

    //TODO: link up id
    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }

    [JsonPropertyName("PKFBCNBNKAM")]
    public string PKFBCNBNKAM { get; set; } = string.Empty;

    [JsonPropertyName("prefabPath")]
    public string PrefabPath { get; set; } = string.Empty;

    [JsonPropertyName("descTextMapHash")]
    public MappedText DescTextMapHash { get; set; }

    [JsonPropertyName("GHKPAHOPGNM")]
    public bool? GHKPAHOPGNM { get; set; }
}
