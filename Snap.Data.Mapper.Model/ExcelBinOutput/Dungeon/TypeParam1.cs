namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dungeon;

public class TypeParam1 : DataObject
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("param1")]
    public int Param1 { get; set; }
}
