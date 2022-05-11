namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.CrystalLink;

public class ActivityCrystalLinkCondBuffExcelConfigData : DataObject
{
    [JsonPropertyName("buffId")]
    public int BuffId { get; set; }

    [JsonPropertyName("FGJONOJPIBD")]
    public string FGJONOJPIBD { get; set; } = default!;

    [JsonPropertyName("abilityName")]
    public string AbilityName { get; set; } = default!;

    [JsonPropertyName("OAJMBKJALAN")]
    public Text OAJMBKJALAN { get; set; }

    [JsonPropertyName("KKGBMGDHBKO")]
    public Text KKGBMGDHBKO { get; set; }

    [JsonPropertyName("AKDJKMBLKEA")]
    public Text AKDJKMBLKEA { get; set; }

    [JsonPropertyName("CKIDKHOIEOP")]
    public int CKIDKHOIEOP { get; set; }

    [JsonPropertyName("CCFGDDHBAPA")]
    public IList<string> CCFGDDHBAPA { get; set; } = default!;
}

