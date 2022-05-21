namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dungeon;

public class DungeonRosterConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("openTimeStr")]
    public string OpenTimeStr { get; set; } = default!;

    [JsonPropertyName("cycleTime")]
    public int CycleTime { get; set; }

    [JsonPropertyName("cycleType")]
    public string CycleType { get; set; } = default!;

    [JsonPropertyName("rosterPool")]
    public IList<DungeonListWrapper> RosterPool { get; set; } = default!;
}