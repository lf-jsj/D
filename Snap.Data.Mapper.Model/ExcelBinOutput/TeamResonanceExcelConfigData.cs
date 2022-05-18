namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class TeamResonanceExcelConfigData : DataObject
{
    [JsonPropertyName("teamResonanceId")]
    public int TeamResonanceId { get; set; }

    [JsonPropertyName("teamResonanceGroupId")]
    public int TeamResonanceGroupId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("fireAvatarCount")]
    public int FireAvatarCount { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("openConfig")]
    public string OpenConfig { get; set; } = default!;

    [JsonPropertyName("addProps")]
    public IList<DataObject> AddProps { get; set; } = default!;

    [JsonPropertyName("paramList")]
    public IList<double> ParamList { get; set; } = default!;

    [JsonPropertyName("waterAvatarCount")]
    public int? WaterAvatarCount { get; set; }

    [JsonPropertyName("windAvatarCount")]
    public int? WindAvatarCount { get; set; }

    [JsonPropertyName("electricAvatarCount")]
    public int? ElectricAvatarCount { get; set; }

    [JsonPropertyName("iceAvatarCount")]
    public int? IceAvatarCount { get; set; }

    [JsonPropertyName("rockAvatarCount")]
    public int? RockAvatarCount { get; set; }

    [JsonPropertyName("cond")]
    public string Cond { get; set; } = default!;
}