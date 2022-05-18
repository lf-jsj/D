namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weather;

public class WeatherTemplateExcelConfigData : DataObject
{
    [JsonPropertyName("templateName")]
    public string TemplateName { get; set; } = default!;

    [JsonPropertyName("weatherType")]
    public string WeatherType { get; set; } = default!;

    [JsonPropertyName("sunnyProb")]
    public double SunnyProb { get; set; }

    [JsonPropertyName("cloudyProb")]
    public double CloudyProb { get; set; }

    [JsonPropertyName("rainProb")]
    public double RainProb { get; set; }

    [JsonPropertyName("thunderstormProb")]
    public double ThunderstormProb { get; set; }

    [JsonPropertyName("snowProb")]
    public double? SnowProb { get; set; }

    [JsonPropertyName("mistProb")]
    public double? MistProb { get; set; }
}