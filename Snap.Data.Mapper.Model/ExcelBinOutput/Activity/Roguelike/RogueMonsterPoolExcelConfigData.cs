namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Roguelike;

public class RogueMonsterPoolExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("KBOEBDEPNIA")]
    public IList<int> KBOEBDEPNIA { get; set; } = default!;

    [JsonPropertyName("difficulty")]
    public string Difficulty { get; set; } = default!;
}