namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class EntityMultiPlayerExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("propPerVec")]
    public IList<PropPerVec> PropPerVec { get; set; }

    [JsonPropertyName("endureNumVec")]
    public IList<int> EndureNumVec { get; set; }

    [JsonPropertyName("elementShieldPerVec")]
    public IList<double> ElementShieldPerVec { get; set; }
}
