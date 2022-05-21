namespace Snap.Data.Mapper.Model.Common.Param;

public class ActionTypeParam<TParam> : DataObject
{
    [JsonPropertyName("actionType")]
    public string ActionType { get; set; } = default!;

    [JsonPropertyName("param")]
    public TParam Param { get; set; } = default!;
}
