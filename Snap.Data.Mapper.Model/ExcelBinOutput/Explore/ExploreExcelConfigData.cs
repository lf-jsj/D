namespace Snap.Data.Mapper.Model.ExcelBinOutput.Explore;

public class ExploreExcelConfigData : DataObject
{
    [JsonPropertyName("materialID")]
    public int MaterialID { get; set; }

    [JsonPropertyName("exp")]
    public int Exp { get; set; }
}