namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Potion;

public class ActivityPotionLevelExcelConfigData : DataObject
{
    [JsonPropertyName("levelId")]
    public int LevelId { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("MEGOKFJDLCK")]
    public int MEGOKFJDLCK { get; set; }

    [JsonPropertyName("OMGNPBMKAIK")]
    public IList<int> OMGNPBMKAIK { get; set; } = default!;

    [JsonPropertyName("CNLNFAJNNCK")]
    public IList<int> CNLNFAJNNCK { get; set; } = default!;

    [JsonPropertyName("EPABBOCLIOP")]
    public IList<int> EPABBOCLIOP { get; set; } = default!;

    [JsonPropertyName("MGHJLMBFCKC")]
    public IList<int> MGHJLMBFCKC { get; set; } = default!;
}