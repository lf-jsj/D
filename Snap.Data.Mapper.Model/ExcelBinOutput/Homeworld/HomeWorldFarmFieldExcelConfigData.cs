namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldFarmFieldExcelConfigData : DataObject
{
    [JsonPropertyName("GGOPMNNBGFE")]
    public int GGOPMNNBGFE { get; set; }

    [JsonPropertyName("BCGGLHFNGOE")]
    public string BCGGLHFNGOE { get; set; } = default!;

    [JsonPropertyName("PEFOGBJCAEO")]
    public int PEFOGBJCAEO { get; set; }

    [JsonPropertyName("CMGFOJAHLAF")]
    public int CMGFOJAHLAF { get; set; }

    [JsonPropertyName("IGCLPPLCAGN")]
    public IList<int> IGCLPPLCAGN { get; set; } = default!;
}