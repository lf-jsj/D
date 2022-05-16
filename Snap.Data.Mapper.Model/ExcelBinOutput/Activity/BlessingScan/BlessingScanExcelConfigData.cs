namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BlessingScan;

public class BlessingScanExcelConfigData : DataObject
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("typeId")]
    public int TypeId { get; set; }

    [JsonPropertyName("scanType")]
    public string ScanType { get; set; } = default!;

    [JsonPropertyName("refId")]
    public int RefId { get; set; }

    [JsonPropertyName("picUpConfig")]
    public IList<PicUpConfig> PicUpConfig { get; set; } = default!;

    [JsonPropertyName("scanTime")]
    public int ScanTime { get; set; }

    [JsonPropertyName("hitBoxesNodeName")]
    public string HitBoxesNodeName { get; set; } = default!;
}
