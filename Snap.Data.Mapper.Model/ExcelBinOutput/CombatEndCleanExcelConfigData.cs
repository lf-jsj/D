namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class CombatEndCleanExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("LANLNJICKHH")]
    public string LANLNJICKHH { get; set; } = default!;

    [JsonPropertyName("OIMIHADMMNE")]
    public IList<string> OIMIHADMMNE { get; set; } = default!;
}