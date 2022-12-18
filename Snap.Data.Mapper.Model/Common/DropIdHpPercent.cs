namespace Snap.Data.Mapper.Model.Common;

public class DropIdHpPercent : DataObject
{
    [JsonPropertyName("dropId")]
    public int DropId { get; set; }

    [JsonPropertyName("hpPercent")]
    public float HpPercent { get; set; }
}
