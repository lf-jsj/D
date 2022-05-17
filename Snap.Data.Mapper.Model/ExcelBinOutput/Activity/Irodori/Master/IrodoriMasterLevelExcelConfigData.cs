namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Irodori.Master;

public class IrodoriMasterLevelExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("LFOFAGBPPKG")]
    public int LFOFAGBPPKG { get; set; }

    [JsonPropertyName("galleryId")]
    public int GalleryId { get; set; }

    [JsonPropertyName("EIIGCOCPOPH")]
    public string EIIGCOCPOPH { get; set; } = default!;

    [JsonPropertyName("trialAvatarList")]
    public IList<int> TrialAvatarList { get; set; } = default!;

    [JsonPropertyName("watcherList")]
    public IList<int> WatcherList { get; set; } = default!;
}