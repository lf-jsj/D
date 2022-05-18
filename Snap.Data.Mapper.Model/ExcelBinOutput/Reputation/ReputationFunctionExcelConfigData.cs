namespace Snap.Data.Mapper.Model.ExcelBinOutput.Reputation;

public class ReputationFunctionExcelConfigData : DataObject
{

    [JsonPropertyName("functionId")]
    public int FunctionId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("shopDescTextMapHash")]
    public Text ShopDescTextMapHash { get; set; }
}