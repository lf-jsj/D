namespace Snap.Data.Mapper.Model.ExcelBinOutput.CustomLevel;

public class CustomLevelTagConfigData : DataObject
{
    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("PMJKHMJFPDE")]
    public Text PMJKHMJFPDE { get; set; }

    [JsonPropertyName("sortId")]
    public int SortId { get; set; }

    [JsonPropertyName("isDefault")]
    public bool IsDefault { get; set; }
}
