namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.TrialAvatar;

public class TrialReliquaryExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("ReliquaryId")]
    public int ReliquaryId { get; set; }

    [JsonPropertyName("Level")]
    public int Level { get; set; }

    [JsonPropertyName("MainPropId")]
    public int MainPropId { get; set; }

    [JsonPropertyName("AppendPropList")]
    public IList<int> AppendPropList { get; set; } = default!;
}