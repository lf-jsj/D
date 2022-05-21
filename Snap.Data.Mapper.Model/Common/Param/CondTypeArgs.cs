namespace Snap.Data.Mapper.Model.Common.Param;

public class CondTypeArgs : DataObject
{
    [JsonPropertyName("condType")]
    public string CondType { get; set; } = default!;

    [JsonPropertyName("args")]
    public IList<int> Args { get; set; } = default!;
}
