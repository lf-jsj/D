namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Photograph;

public class ActivityPhotographPosExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("BADIMLGKNCF")]
    public int BADIMLGKNCF { get; set; }

    [JsonPropertyName("IANADEPLAOB")]
    public Text IANADEPLAOB { get; set; }

    [JsonPropertyName("ELMNAGPMOCM")]
    public Text ELMNAGPMOCM { get; set; }

    [JsonPropertyName("LCKJKFBCGPO")]
    public Text LCKJKFBCGPO { get; set; }

    [JsonPropertyName("NGCPIALBENK")]
    public Text NGCPIALBENK { get; set; }

    [JsonPropertyName("EOCIHEJDIGI")]
    public Text EOCIHEJDIGI { get; set; }

    [JsonPropertyName("CFKNPNGFFLF")]
    public string CFKNPNGFFLF { get; set; } = default!;

    [JsonPropertyName("KNFNHPCGDEA")]
    public string KNFNHPCGDEA { get; set; } = default!;

    [JsonPropertyName("IBPGFFKFFEM")]
    public int IBPGFFKFFEM { get; set; }

    [JsonPropertyName("OGCCOKMNGFJ")]
    public Text OGCCOKMNGFJ { get; set; }

    [JsonPropertyName("HFJABFMDNNM")]
    public IList<int> HFJABFMDNNM { get; set; } = default!;

    [JsonPropertyName("PEBPOOGAKFK")]
    [DataArray(Length = 4)]
    public IList<Text> PEBPOOGAKFK { get; set; } = default!;

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("watcherId")]
    public int WatcherId { get; set; }

    [JsonPropertyName("galleryId")]
    public int GalleryId { get; set; }

    [JsonPropertyName("ANJOIPLLHPK")]
    public int ANJOIPLLHPK { get; set; }
}