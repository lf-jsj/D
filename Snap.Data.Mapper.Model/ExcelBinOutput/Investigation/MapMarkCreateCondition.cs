namespace Snap.Data.Mapper.Model.ExcelBinOutput.Investigation;

public class MapMarkCreateCondition : DataObject
{
    [JsonPropertyName("conditionType")]
    public string ConditionType { get; set; } = default!;

    [JsonPropertyName("conditionParam")]
    public int? ConditionParam { get; set; }
}
