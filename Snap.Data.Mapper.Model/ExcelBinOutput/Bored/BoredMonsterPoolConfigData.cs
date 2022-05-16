namespace Snap.Data.Mapper.Model.ExcelBinOutput.Bored;

public class BoredMonsterPoolConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("monsterId")]
    public int MonsterId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("dropTag")]
    public string DropTag { get; set; } = default!;

    [JsonPropertyName("affixVec")]
    public IList<DataObject> AffixVec { get; set; } = default!;

    [JsonPropertyName("isElite")]
    public bool IsElite { get; set; }
}