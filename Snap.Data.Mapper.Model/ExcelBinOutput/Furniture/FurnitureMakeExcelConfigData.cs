namespace Snap.Data.Mapper.Model.ExcelBinOutput.Furniture;
public class FurnitureMakeExcelConfigData : DataObject
{
    [JsonPropertyName("configID")]
    public int ConfigID { get; set; }

    [JsonPropertyName("furnitureItemID")]
    public int FurnitureItemID { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("exp")]
    public int Exp { get; set; }

    [JsonPropertyName("materialItems")]
    public IList<MaterialItem> MaterialItems { get; set; } = default!;

    [JsonPropertyName("makeTime")]
    public int MakeTime { get; set; }

    [JsonPropertyName("maxAccelerateTime")]
    public int MaxAccelerateTime { get; set; }

    [JsonPropertyName("quickFetchMaterialNum")]
    public int QuickFetchMaterialNum { get; set; }
}
