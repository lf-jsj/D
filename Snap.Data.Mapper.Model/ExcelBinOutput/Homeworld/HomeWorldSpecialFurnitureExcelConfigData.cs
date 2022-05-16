namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldSpecialFurnitureExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("furnitureID")]
    public int FurnitureID { get; set; }

    [JsonPropertyName("sceneID")]
    public int SceneID { get; set; }

    [JsonPropertyName("gadgetID")]
    public IList<int> GadgetID { get; set; } = default!;
}