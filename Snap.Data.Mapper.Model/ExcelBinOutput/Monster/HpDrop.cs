namespace Snap.Data.Mapper.Model.ExcelBinOutput.Monster;

public class HpDrop : DataObject
{
    [JsonPropertyName("dropId")]
    public int DropId { get; set; }

    [JsonPropertyName("hpPercent")]
    public double HpPercent { get; set; }
}
