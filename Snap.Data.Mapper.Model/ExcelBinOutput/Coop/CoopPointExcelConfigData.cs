namespace Snap.Data.Mapper.Model.ExcelBinOutput.Coop;

public class CoopPointExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("chapterId")]
    public int ChapterId { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("acceptQuest")]
    public int AcceptQuest { get; set; }

    [JsonPropertyName("postPointList")]
    public IList<int> PostPointList { get; set; } = default!;

    [JsonPropertyName("pointNameTextMapHash")]
    public Text PointNameTextMapHash { get; set; }

    [JsonPropertyName("pointDecTextMapHash")]
    public Text PointDecTextMapHash { get; set; }

    [JsonPropertyName("pointPosId")]
    public int PointPosId { get; set; }

    [JsonPropertyName("photoMaleHashSuffix")]
    public HashSuffix? PhotoMaleHashSuffix { get; set; }

    [JsonPropertyName("photoMaleHashPre")]
    public HashPre? PhotoMaleHashPre { get; set; }

    [JsonPropertyName("photoFemaleHashSuffix")]
    public HashSuffix? PhotoFemaleHashSuffix { get; set; }

    [JsonPropertyName("photoFemaleHashPre")]
    public HashPre? PhotoFemaleHashPre { get; set; }
}
