namespace Snap.Data.Mapper.Model.ExcelBinOutput.Exhibition;

public class ExhibitionListExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("HDMDPHCDHNO")]
    public int HDMDPHCDHNO { get; set; }

    [JsonPropertyName("ICLIPNDHNDO")]
    public int ICLIPNDHNDO { get; set; }

    [JsonPropertyName("OCNDNMLINDG")]
    public Text OCNDNMLINDG { get; set; }

    [JsonPropertyName("GNJKPEFBIOA")]
    public Text GNJKPEFBIOA { get; set; }

    [JsonPropertyName("displayType")]
    public string DisplayType { get; set; } = default!;
}