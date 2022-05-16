namespace Snap.Data.Mapper.Model.ExcelBinOutput.Explore;
public class ExploreAreaTotalExpExcelConfigData : DataObject
{
    [JsonPropertyName("areaID")]
    public int AreaID { get; set; }

    [JsonPropertyName("totalExp")]
    public int TotalExp { get; set; }

    [JsonPropertyName("JNBOPGBDCDJ")]
    public double? JNBOPGBDCDJ { get; set; }
}