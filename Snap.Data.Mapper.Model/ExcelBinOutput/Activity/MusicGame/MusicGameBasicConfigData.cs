namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.MusicGame;

public class MusicGameBasicConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("musicID")]
    public int MusicID { get; set; }

    [JsonPropertyName("musicLevel")]
    public int MusicLevel { get; set; }

    [JsonPropertyName("jsonPath")]
    public string JsonPath { get; set; } = default!;

    [JsonPropertyName("HEPAKGHLEKM")]
    public int HEPAKGHLEKM { get; set; }

    [JsonPropertyName("KEFFLFAENIO")]
    public double KEFFLFAENIO { get; set; }

    [JsonPropertyName("LCAPNKKIOHG")]
    public int LCAPNKKIOHG { get; set; }

    [JsonPropertyName("successPrePoint")]
    public double SuccessPrePoint { get; set; }

    [JsonPropertyName("successLatePoint")]
    public double SuccessLatePoint { get; set; }

    [JsonPropertyName("scaleTime")]
    public int ScaleTime { get; set; }

    [JsonPropertyName("scaleRange")]
    public double ScaleRange { get; set; }

    [JsonPropertyName("scoreLevelList")]
    public IList<int> ScoreLevelList { get; set; } = default!;

    [JsonPropertyName("scoreOneKey")]
    public int ScoreOneKey { get; set; }

    [JsonPropertyName("comboConfig")]
    public IList<ComboUpLimitRate> ComboConfig { get; set; } = default!;

    [JsonPropertyName("unlockTipsTextMapHash")]
    public Text UnlockTipsTextMapHash { get; set; }

    [JsonPropertyName("INOAKFACPHC")]
    public IList<OILMPMKAIPGDJDAHKCOBJFHAGMMLFIIED> INOAKFACPHC { get; set; } = default!;
}