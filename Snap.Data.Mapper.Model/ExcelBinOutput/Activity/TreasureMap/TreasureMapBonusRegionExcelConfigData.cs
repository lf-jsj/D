namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.TreasureMap;
public class TreasureMapBonusRegionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("FFEGHOCALNL")]
    public int FFEGHOCALNL { get; set; }

    [JsonPropertyName("reviseLevel")]
    public int ReviseLevel { get; set; }

    [JsonPropertyName("mapTitleTextMapHash")]
    public Text MapTitleTextMapHash { get; set; }

    [JsonPropertyName("mapDescTextMapHash")]
    public Text MapDescTextMapHash { get; set; }

    [JsonPropertyName("showImage")]
    public string ShowImage { get; set; } = default!;

    [JsonPropertyName("EJFOCEDMNPM")]
    public int EJFOCEDMNPM { get; set; }

    [JsonPropertyName("regionCenter")]
    public IList<float> RegionCenter { get; set; } = default!;

    [JsonPropertyName("regionRadius")]
    public int RegionRadius { get; set; }

    [JsonPropertyName("unlockRegionId")]
    public int? UnlockRegionId { get; set; }
}
