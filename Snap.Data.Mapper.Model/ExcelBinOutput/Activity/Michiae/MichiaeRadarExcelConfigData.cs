namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Michiae;

public class MichiaeRadarExcelConfigData : DataObject
{
    [JsonPropertyName("JCDIPNHPFJB")]
    public string JCDIPNHPFJB { get; set; } = default!;

    [JsonPropertyName("OILLEGMFHJM")]
    public IList<int> OILLEGMFHJM { get; set; } = default!;
}