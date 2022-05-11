namespace Snap.Data.Mapper.Model.ExcelBinOutput.Animal;

public class AnimalCodexExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("describeId")]
    public int DescribeId { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("BAINKHIIMJE")]
    public string BAINKHIIMJE { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("modelPath")]
    public string ModelPath { get; set; } = default!;

    [JsonPropertyName("pushTipsCodexId")]
    public int? PushTipsCodexId { get; set; }

    [JsonPropertyName("subType")]
    public string SubType { get; set; } = default!;

    [JsonPropertyName("isDisuse")]
    public bool? IsDisuse { get; set; }

    [JsonPropertyName("isSeenActive")]
    public bool? IsSeenActive { get; set; }

    [JsonPropertyName("showOnlyUnlocked")]
    public bool? ShowOnlyUnlocked { get; set; }
}
