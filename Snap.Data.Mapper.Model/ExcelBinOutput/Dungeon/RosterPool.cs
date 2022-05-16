namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dungeon;

public class RosterPool : DataObject
{
    [JsonPropertyName("dungeonList")]
    public IList<int> DungeonList { get; set; } = default!;
}
