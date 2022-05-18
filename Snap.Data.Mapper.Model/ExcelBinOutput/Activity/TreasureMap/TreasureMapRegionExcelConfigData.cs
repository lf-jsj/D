namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.TreasureMap;

public class TreasureMapRegionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("unlockDay")]
    public int UnlockDay { get; set; }

    [JsonPropertyName("tokenNum")]
    public int TokenNum { get; set; }

    [JsonPropertyName("regionCenter")]
    public IList<double> RegionCenter { get; set; } = default!;

    [JsonPropertyName("regionRadius")]
    public int RegionRadius { get; set; }

    [JsonPropertyName("regionEntryId")]
    public int RegionEntryId { get; set; }

    [JsonPropertyName("groupList")]
    public IList<int> GroupList { get; set; } = default!;

    [JsonPropertyName("reviseLevel")]
    public int ReviseLevel { get; set; }

    [JsonPropertyName("spotNumList")]
    public IList<int> SpotNumList { get; set; } = default!;

    [JsonPropertyName("tokenNumList")]
    public IList<int> TokenNumList { get; set; } = default!;

    [JsonPropertyName("miscDropProbList")]
    public IList<int> MiscDropProbList { get; set; } = default!;

    [JsonPropertyName("miscDropId")]
    public int MiscDropId { get; set; }

    [JsonPropertyName("backupGroupList")]
    public IList<int> BackupGroupList { get; set; } = default!;

    [JsonPropertyName("mpTokenThreshold")]
    public int MpTokenThreshold { get; set; }

    [JsonPropertyName("GPNHKDHKGFJ")]
    public IList<double> GPNHKDHKGFJ { get; set; } = default!;

    [JsonPropertyName("KNGCEIHOKED")]
    public Text KNGCEIHOKED { get; set; }

    [JsonPropertyName("EHJGEDALKEH")]
    public int EHJGEDALKEH { get; set; }

    [JsonPropertyName("mpGroupId")]
    public int? MpGroupId { get; set; }

    [JsonPropertyName("mpTypeId")]
    public int? MpTypeId { get; set; }

    [JsonPropertyName("BBGBJEKJFFB")]
    public int? BBGBJEKJFFB { get; set; }
}