namespace Snap.Data.Mapper.Model.ExcelBinOutput.Expedition;

public class OpenConditionVec : DataObject
{
    [JsonPropertyName("para")]
    public int Para { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("PJNLDIOJPGB")]
    public int? PJNLDIOJPGB { get; set; }
}