namespace Snap.Data.Mapper.Model.ExcelBinOutput.H5Activity;

public class H5ActivityExcelConfigData : DataObject
{
    [JsonPropertyName("h5ActivityId")]
    public int H5ActivityId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("detailTextMapHash")]
    public Text DetailTextMapHash { get; set; }

    [JsonPropertyName("condList")]
    public IList<ParamStrCond> CondList { get; set; } = default!;

    [JsonPropertyName("condComb")]
    public string CondComb { get; set; } = default!;
}
