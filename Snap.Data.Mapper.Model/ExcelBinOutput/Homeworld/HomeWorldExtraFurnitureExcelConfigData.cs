namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldExtraFurnitureExcelConfigData : DataObject
{
    [JsonPropertyName("furnitureID")]
    public int FurnitureID { get; set; }

    [JsonPropertyName("NOHECILICIF")]
    public IList<string> NOHECILICIF { get; set; } = default!;
}