namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Sumo;

public class ActivitySumoStageExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("KMEAOCFFPBK")]
    public int KMEAOCFFPBK { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("watcherList")]
    public IList<int> WatcherList { get; set; } = default!;

    [JsonPropertyName("MFMMELJJFAI")]
    public IList<int> MFMMELJJFAI { get; set; } = default!;

    [JsonPropertyName("OPFGPHPOKOM")]
    public IList<int> OPFGPHPOKOM { get; set; } = default!;

    [JsonPropertyName("DAFGKMPCGGH")]
    public IList<int> DAFGKMPCGGH { get; set; } = default!;

    [JsonPropertyName("galleryId")]
    public int GalleryId { get; set; }

    [JsonPropertyName("MEBDBBDEMMH")]
    public IList<int> MEBDBBDEMMH { get; set; } = default!;

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("OBHGBLBGMNC")]
    public IList<int> OBHGBLBGMNC { get; set; } = default!;

    [JsonPropertyName("EFIMENECJNP")]
    public IList<HPGLJGCCMFFLGFBKELLAEI> EFIMENECJNP { get; set; } = default!;

    [JsonPropertyName("FNFGOEDEPDN")]
    public IList<int> FNFGOEDEPDN { get; set; } = default!;

    [JsonPropertyName("HEPMJDDFLCA")]
    public IList<int> HEPMJDDFLCA { get; set; } = default!;

    [JsonPropertyName("PBKCPAHJONA")]
    public string? PBKCPAHJONA { get; set; }
}
