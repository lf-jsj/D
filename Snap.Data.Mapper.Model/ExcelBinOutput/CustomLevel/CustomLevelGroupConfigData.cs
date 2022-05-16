namespace Snap.Data.Mapper.Model.ExcelBinOutput.CustomLevel;

public class CustomLevelGroupConfigData : DataObject
{
    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("dungeonList")]
    public IList<int> DungeonList { get; set; } = default!;

    [JsonPropertyName("PALHNFLOIOG")]
    public IList<int> PALHNFLOIOG { get; set; } = default!;

    [JsonPropertyName("GJALJIDIKMC")]
    public int GJALJIDIKMC { get; set; }

    [JsonPropertyName("MGMPNPFJBDO")]
    public int MGMPNPFJBDO { get; set; }

    [JsonPropertyName("LMOAAEGEJJN")]
    public int LMOAAEGEJJN { get; set; }

    [JsonPropertyName("KGJBBBBMJBH")]
    public int KGJBBBBMJBH { get; set; }

    [JsonPropertyName("ELPANLKFKIL")]
    public int ELPANLKFKIL { get; set; }

    [JsonPropertyName("PNEPFDKFGBN")]
    public int PNEPFDKFGBN { get; set; }
}
