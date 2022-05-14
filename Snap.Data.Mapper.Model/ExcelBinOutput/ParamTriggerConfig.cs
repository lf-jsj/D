namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ParamTriggerConfig : DataObject
{
    [JsonPropertyName("TriggerType")]
    public string TriggerType { get; set; } = default!;

    [JsonPropertyName("Param")]
    public IList<string> Param { get; set; } = default!;
}

