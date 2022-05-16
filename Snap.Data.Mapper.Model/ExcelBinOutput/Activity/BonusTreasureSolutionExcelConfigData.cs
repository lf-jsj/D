namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity;
public class BonusTreasureSolutionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("PCPAAELOONE")]
    public Text PCPAAELOONE { get; set; }

    [JsonPropertyName("IHMJGMOENDB")]
    public int IHMJGMOENDB { get; set; }

    [JsonPropertyName("JMLEFOFDCIL")]
    public IList<int> JMLEFOFDCIL { get; set; } = default!;
}
