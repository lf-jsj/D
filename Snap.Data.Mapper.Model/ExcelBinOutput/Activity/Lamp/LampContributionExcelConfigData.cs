namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Lamp;
public class LampContributionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("contribution")]
    public int Contribution { get; set; }
}
