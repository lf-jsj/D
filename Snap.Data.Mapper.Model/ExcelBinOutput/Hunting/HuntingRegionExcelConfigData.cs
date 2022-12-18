namespace Snap.Data.Mapper.Model.ExcelBinOutput.Hunting;

public class HuntingRegionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("centerPosList")]
    public IList<float> CenterPosList { get; set; } = default!;

    [JsonPropertyName("centerRadius")]
    public int CenterRadius { get; set; }

    [JsonPropertyName("safeClueGroup")]
    public IList<int> SafeClueGroup { get; set; } = default!;

    [JsonPropertyName("clueGroup")]
    public IList<int> ClueGroup { get; set; } = default!;

    [JsonPropertyName("safeDestinationGroup")]
    public IList<int> SafeDestinationGroup { get; set; } = default!;

    [JsonPropertyName("destinationGroup")]
    public IList<int> DestinationGroup { get; set; } = default!;

    [JsonPropertyName("regionInfoTextMapHash")]
    public Text RegionInfoTextMapHash { get; set; }

    [JsonPropertyName("OOPCIIPKHPE")]
    public IList<int> OOPCIIPKHPE { get; set; } = default!;
}