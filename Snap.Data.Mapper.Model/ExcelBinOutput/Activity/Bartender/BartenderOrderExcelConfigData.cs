namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Bartender;

public class BartenderOrderExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("MPJNHPOLGBI")]
    public int MPJNHPOLGBI { get; set; }

    [JsonPropertyName("CBIGJEIHGNC")]
    public IList<int> CBIGJEIHGNC { get; set; } = default!;

    [JsonPropertyName("iconName")]
    public string IconName { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("KIDLFMMCHML")]
    public string KIDLFMMCHML { get; set; } = default!;

    [JsonPropertyName("time")]
    public int? Time { get; set; }

    [JsonPropertyName("score")]
    public int? Score { get; set; }
}
