namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class MechanicusMapExcelConfigData : DataObject
{
    [JsonPropertyName("mechanicusMapID")]
    public int MechanicusMapID { get; set; }

    [JsonPropertyName("mapNameTextMapHash")]
    public Text MapNameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("unlockTipsTextMapHash")]
    public Text UnlockTipsTextMapHash { get; set; }

    [JsonPropertyName("mapIconPath")]
    public string MapIconPath { get; set; } = default!;

    [JsonPropertyName("buildGearLimit")]
    public int BuildGearLimit { get; set; }

    [JsonPropertyName("dungeonID")]
    public int DungeonID { get; set; }
}