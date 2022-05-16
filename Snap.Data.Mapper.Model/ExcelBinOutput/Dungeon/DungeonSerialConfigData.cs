namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dungeon;

public class DungeonSerialConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("MaxTakeNum")]
    public int MaxTakeNum { get; set; }

    [JsonPropertyName("takeCost")]
    public int TakeCost { get; set; }
}