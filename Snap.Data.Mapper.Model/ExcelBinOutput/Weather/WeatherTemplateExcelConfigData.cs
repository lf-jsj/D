namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weather;

public class WeatherTemplateExcelConfigData : DataObject
{
    [JsonPropertyName("templateName")]
    public string TemplateName { get; set; } = default!;

    [JsonPropertyName("weatherType")]
    public string WeatherType { get; set; } = default!;

    [JsonPropertyName("sunnyProb")]
    public float SunnyProb { get; set; }

    [JsonPropertyName("cloudyProb")]
    public float CloudyProb { get; set; }

    [JsonPropertyName("rainProb")]
    public float RainProb { get; set; }

    [JsonPropertyName("thunderstormProb")]
    public float ThunderstormProb { get; set; }

    [JsonPropertyName("snowProb")]
    public float? SnowProb { get; set; }

    [JsonPropertyName("mistProb")]
    public float? MistProb { get; set; }
}