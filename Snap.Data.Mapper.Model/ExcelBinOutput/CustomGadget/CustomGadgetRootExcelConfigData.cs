namespace Snap.Data.Mapper.Model.ExcelBinOutput.CustomGadget;

public class CustomGadgetRootExcelConfigData : DataObject
{
    [JsonPropertyName("PACNLBMOLFE")]
    public int PACNLBMOLFE { get; set; }

    [JsonPropertyName("JHAGACFIOFM")]
    public string JHAGACFIOFM { get; set; } = default!;

    [JsonPropertyName("EPPJELMCHJI")]
    public string EPPJELMCHJI { get; set; } = default!;

    [JsonPropertyName("EOPLJNNEDEH")]
    public string EOPLJNNEDEH { get; set; } = default!;

    [JsonPropertyName("IGEFONGLFNA")]
    public IList<int> IGEFONGLFNA { get; set; } = default!;
}
