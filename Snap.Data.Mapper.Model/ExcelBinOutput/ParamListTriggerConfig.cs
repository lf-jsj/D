namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class ParamListTriggerConfig : DataObject
{
    [JsonPropertyName("triggerType")]
    [PrimaryName]
    public string TriggerType { get; set; } = default!;

    //TODO: trigger converters
    [JsonPropertyName("paramList")]
    [DataArray(Length = 4)]
    public IList<string> ParamList { get; set; } = default!;
}
