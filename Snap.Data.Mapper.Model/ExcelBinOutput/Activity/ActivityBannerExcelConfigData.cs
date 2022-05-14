namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity;

public class ActivityBannerExcelConfigData : DataObject
{
    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("LOHDLJEHAHA")]
    public string? LOHDLJEHAHA { get; set; }

    //TODO: link up id
    [JsonPropertyName("rewardPreviewId")]
    public int RewardPreviewId { get; set; }

    [JsonPropertyName("PKFBCNBNKAM")]
    public string PKFBCNBNKAM { get; set; } = default!;

    [JsonPropertyName("prefabPath")]
    public string PrefabPath { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("GHKPAHOPGNM")]
    public bool? GHKPAHOPGNM { get; set; }
}
