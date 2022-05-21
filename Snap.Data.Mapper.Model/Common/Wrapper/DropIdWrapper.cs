namespace Snap.Data.Mapper.Model.Common.Wrapper;

public class DropIdWrapper : DataObject
{
    [JsonPropertyName("dropId")]
    public IList<int> DropId { get; set; } = default!;
}
