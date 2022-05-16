namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dungeon;

public class DungeonLevelEntityConfigData : DataObject
{
    [JsonPropertyName("clientId")]
    public int ClientId { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("show")]
    public bool Show { get; set; }

    [JsonPropertyName("levelConfigName")]
    public string LevelConfigName { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("DOEMJOPMEHK")]
    public Text DOEMJOPMEHK { get; set; }
}
