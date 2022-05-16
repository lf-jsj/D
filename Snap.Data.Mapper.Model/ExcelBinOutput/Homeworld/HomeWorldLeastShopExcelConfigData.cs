namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldLeastShopExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("poolID")]
    public int PoolID { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }
}