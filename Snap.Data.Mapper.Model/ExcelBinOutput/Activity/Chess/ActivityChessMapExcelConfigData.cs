namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Chess;

public class ActivityChessMapExcelConfigData : DataObject
{
    [JsonPropertyName("PMGIABAMPCN")]
    public int PMGIABAMPCN { get; set; }

    [JsonPropertyName("mapNameTextMapHash")]
    public MappedText MapNameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public MappedText DescTextMapHash { get; set; }

    [JsonPropertyName("unlockTipsTextMapHash")]
    public MappedText UnlockTipsTextMapHash { get; set; }

    [JsonPropertyName("mapIconPath")]
    public string MapIconPath { get; set; } = default!;

    [JsonPropertyName("buildGearLimit")]
    public int BuildGearLimit { get; set; }

    [JsonPropertyName("dungeonID")]
    public int DungeonID { get; set; }

    [JsonPropertyName("PAMPLCLLMIH")]
    public int PAMPLCLLMIH { get; set; }

    [JsonPropertyName("LKFNFPEJPJA")]
    public int LKFNFPEJPJA { get; set; }

    [JsonPropertyName("PGPCCOLEFLF")]
    public bool PGPCCOLEFLF { get; set; }

    [JsonPropertyName("show")]
    public bool Show { get; set; }

    [JsonPropertyName("ABFKIDHOIOA")]
    public IList<int> ABFKIDHOIOA { get; set; } = default!;

    [JsonPropertyName("KIALFKIPKPP")]
    public IList<int> KIALFKIPKPP { get; set; } = default!;

    [JsonPropertyName("HFFFPCBHEKE")]
    public int? HFFFPCBHEKE { get; set; }
}
