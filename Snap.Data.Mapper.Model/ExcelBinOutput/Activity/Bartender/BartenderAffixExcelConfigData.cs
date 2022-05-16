namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Bartender;
public class BartenderAffixExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("IFFDMOKFIOD")]
    public string IFFDMOKFIOD { get; set; } = default!;

    [JsonPropertyName("materialId")]
    public int MaterialId { get; set; }

    [JsonPropertyName("IBHNPCBCLAC")]
    public int IBHNPCBCLAC { get; set; }
}