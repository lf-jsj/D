namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldShopSubTagExcelConfigData : DataObject
{
    [JsonPropertyName("subID")]
    public int SubID { get; set; }

    [JsonPropertyName("subTagTextMapHash")]
    public Text SubTagTextMapHash { get; set; }

    [JsonPropertyName("LCGHIPCOCHJ")]
    public bool? LCGHIPCOCHJ { get; set; }
}