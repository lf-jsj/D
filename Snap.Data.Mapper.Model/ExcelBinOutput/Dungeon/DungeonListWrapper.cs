namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dungeon;

public class DungeonListWrapper : DataObject
{
    [JsonPropertyName("dungeonList")]
    public IList<int> DungeonList { get; set; } = default!;
}
