namespace Snap.Data.Mapper.Model.ExcelBinOutput.Forge;

public class ForgeRandomExcelConfigData : DataObject
{
    [JsonPropertyName("forgeRandomId")]
    public int ForgeRandomId { get; set; }

    [JsonPropertyName("mainRandomItems")]
    public IList<MainRandomItem> MainRandomItems { get; set; } = default!;
}