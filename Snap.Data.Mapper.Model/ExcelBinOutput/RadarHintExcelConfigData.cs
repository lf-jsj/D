namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class RadarHintExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("GCHHOEEABGE")]
    public string GCHHOEEABGE { get; set; } = default!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = default!;

    [JsonPropertyName("radius")]
    public double Radius { get; set; }

    [JsonPropertyName("effectName")]
    public string EffectName { get; set; } = default!;

    [JsonPropertyName("iconName")]
    public string IconName { get; set; } = default!;

    [JsonPropertyName("audioName")]
    public string AudioName { get; set; } = default!;

    [JsonPropertyName("offsetRadius")]
    public double? OffsetRadius { get; set; }

    [JsonPropertyName("areaRadius")]
    public double? AreaRadius { get; set; }
}