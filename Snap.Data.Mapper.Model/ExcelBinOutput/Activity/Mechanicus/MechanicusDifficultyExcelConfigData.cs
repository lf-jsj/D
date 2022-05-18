namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class MechanicusDifficultyExcelConfigData : DataObject
{
    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("dungeonList")]
    public IList<int> DungeonList { get; set; } = default!;

    [JsonPropertyName("coinRate")]
    public int CoinRate { get; set; }

    [JsonPropertyName("buildGearLimit")]
    public int BuildGearLimit { get; set; }
}