namespace Snap.Data.Mapper.Model.ExcelBinOutput.Aster;

public class AsterMidExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("campVec")]
    public IList<int> CampVec { get; set; } = default!;
}