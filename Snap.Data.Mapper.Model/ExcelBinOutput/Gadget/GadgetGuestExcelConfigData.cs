namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gadget;

public class GadgetGuestExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("showType")]
    public string ShowType { get; set; } = default!;
}