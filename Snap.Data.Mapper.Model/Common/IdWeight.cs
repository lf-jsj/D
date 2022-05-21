namespace Snap.Data.Mapper.Model.Common;
public class IdWeight : DataObject
{
    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}