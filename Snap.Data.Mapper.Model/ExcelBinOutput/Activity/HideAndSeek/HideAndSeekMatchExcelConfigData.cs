namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.HideAndSeek;

public class HideAndSeekMatchExcelConfigData : DataObject
{
    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("unlockTipsTextMapHash")]
    public Text UnlockTipsTextMapHash { get; set; }

    [JsonPropertyName("FOMLKDJFIGL")]
    public Text FOMLKDJFIGL { get; set; }

    [JsonPropertyName("GEHCGGBAEHF")]
    public Text GEHCGGBAEHF { get; set; }

    [JsonPropertyName("dscTextMapHash")]
    public Text DscTextMapHash { get; set; }

    [JsonPropertyName("mapIconPathHashSuffix")]
    public HashSuffix MapIconPathHashSuffix { get; set; }

    [JsonPropertyName("mapSmallIconPathHashPre")]
    public HashPre MapSmallIconPathHashPre { get; set; }

    [JsonPropertyName("mapIconPathHashPre")]
    public HashPre MapIconPathHashPre { get; set; }

    [JsonPropertyName("mapSmallIconPathHashSuffix")]
    public HashSuffix MapSmallIconPathHashSuffix { get; set; }

    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("transportPointList")]
    public IList<int> TransportPointList { get; set; } = default!;

    [JsonPropertyName("durationList")]
    public IList<int> DurationList { get; set; } = default!;

    [JsonPropertyName("galleryID")]
    public int GalleryID { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("cond")]
    public IList<ParamType> Cond { get; set; } = default!;
}