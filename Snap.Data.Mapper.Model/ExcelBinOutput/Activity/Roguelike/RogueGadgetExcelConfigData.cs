namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Roguelike;

public class RogueGadgetExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("JJABKGNJMBG")]
    public string JJABKGNJMBG { get; set; } = default!;

    [JsonPropertyName("gadgetId")]
    public int GadgetId { get; set; }

    [JsonPropertyName("OJEEGENALAE")]
    public IList<OJEEGENALAE> OJEEGENALAE { get; set; } = default!;
}
