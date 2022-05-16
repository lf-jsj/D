namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldBgmExcelConfigData : DataObject
{
    [JsonPropertyName("CFALAEACPKA")]
    public int CFALAEACPKA { get; set; }

    [JsonPropertyName("GGBCGAGHAOA")]
    public bool GGBCGAGHAOA { get; set; }

    [JsonPropertyName("GAHJIKPOENE")]
    public bool GAHJIKPOENE { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("sortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("CMNOOKMFALH")]
    public string CMNOOKMFALH { get; set; } = default!;

    [JsonPropertyName("EMMHFAJDACK")]
    public Text EMMHFAJDACK { get; set; }

    [JsonPropertyName("JEGDGCKPKPK")]
    public bool? JEGDGCKPKPK { get; set; }
}
public class HomeWorldComfortLevelExcelConfigData : DataObject
{
    [JsonPropertyName("levelID")]
    public int LevelID { get; set; }

    [JsonPropertyName("homeCoinProduceRate")]
    public int HomeCoinProduceRate { get; set; }

    [JsonPropertyName("companionshipExpProduceRate")]
    public int CompanionshipExpProduceRate { get; set; }

    [JsonPropertyName("levelNameTextMapHash")]
    public Text LevelNameTextMapHash { get; set; }

    [JsonPropertyName("levelIconHashSuffix")]
    public HashSuffix LevelIconHashSuffix { get; set; }

    [JsonPropertyName("levelIconHashPre")]
    public HashPre LevelIconHashPre { get; set; }

    [JsonPropertyName("comfort")]
    public int? Comfort { get; set; }
}