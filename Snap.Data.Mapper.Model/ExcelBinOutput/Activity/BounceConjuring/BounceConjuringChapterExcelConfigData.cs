namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BounceConjuring;
public class BounceConjuringChapterExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("chapterId")]
    public int ChapterId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("galleryId")]
    public int GalleryId { get; set; }

    [JsonPropertyName("GKAEGAANEIA")]
    public int GKAEGAANEIA { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("IOJDAGIFNKA")]
    public IList<int> IOJDAGIFNKA { get; set; } = default!;

    [JsonPropertyName("ACEDMFOHOOK")]
    public IList<int> ACEDMFOHOOK { get; set; } = default!;

    [JsonPropertyName("IGMNEIAIKID")]
    public IList<int> IGMNEIAIKID { get; set; } = default!;

    [JsonPropertyName("FGKGOPAKKEO")]
    public IList<DataObject> FGKGOPAKKEO { get; set; } = default!;

    [JsonPropertyName("pos")]
    public IList<double> Pos { get; set; } = default!;
}
