namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Bartender;

public class BartenderTaskOrderExcelConfigData : DataObject
{
    [JsonPropertyName("questId")]
    public int QuestId { get; set; }

    [JsonPropertyName("PCJDHNGAKEF")]
    public IList<int> PCJDHNGAKEF { get; set; } = default!;

    [JsonPropertyName("IOGPCAJJNFC")]
    public int IOGPCAJJNFC { get; set; }

    [JsonPropertyName("NDMDJNELHOO")]
    public int NDMDJNELHOO { get; set; }

    [JsonPropertyName("PEICKDNOPNL")]
    public int PEICKDNOPNL { get; set; }

    [JsonPropertyName("IOOAJHEDKGP")]
    public int? IOOAJHEDKGP { get; set; }

    [JsonPropertyName("KOMFFIPNGPP")]
    public bool? KOMFFIPNGPP { get; set; }
}
