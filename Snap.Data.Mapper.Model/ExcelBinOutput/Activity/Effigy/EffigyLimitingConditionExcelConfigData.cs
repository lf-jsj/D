namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Effigy;

public class EffigyLimitingConditionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("conditionType")]
    public string ConditionType { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("conditionParam1")]
    public int ConditionParam1 { get; set; }

    [JsonPropertyName("NMAMMPKNHGI")]
    public IList<int> NMAMMPKNHGI { get; set; }

    [JsonPropertyName("JAMIEJNONLM")]
    public Text JAMIEJNONLM { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("exclusiveId")]
    public int? ExclusiveId { get; set; }

    [JsonPropertyName("ADCHFBPLJPO")]
    public bool? ADCHFBPLJPO { get; set; }
}
