namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Spice;

public class ActivitySpiceFoodExcelConfigData : DataObject
{
    [JsonPropertyName("PFLLNEDIEKN")]
    public int PFLLNEDIEKN { get; set; }

    [JsonPropertyName("KHNJMOOAONG")]
    public int KHNJMOOAONG { get; set; }

    [JsonPropertyName("MJEKOMFMAFD")]
    public int MJEKOMFMAFD { get; set; }

    [JsonPropertyName("KNDJLGFNCCG")]
    public Text KNDJLGFNCCG { get; set; }
}