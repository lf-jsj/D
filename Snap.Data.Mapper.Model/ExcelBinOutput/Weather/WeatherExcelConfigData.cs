namespace Snap.Data.Mapper.Model.ExcelBinOutput.Weather;
public class WeatherExcelConfigData : DataObject
{
    [JsonPropertyName("areaID")]
    public int AreaID { get; set; }

    [JsonPropertyName("weatherAreaId")]
    public int WeatherAreaId { get; set; }

    [JsonPropertyName("maxHeightStr")]
    public string MaxHeightStr { get; set; } = default!;

    [JsonPropertyName("gadgetID")]
    public int GadgetID { get; set; }

    [JsonPropertyName("isDefaultValid")]
    public bool IsDefaultValid { get; set; }

    [JsonPropertyName("templateName")]
    public string TemplateName { get; set; } = default!;

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("profileName")]
    public string ProfileName { get; set; } = default!;

    [JsonPropertyName("defaultClimate")]
    public string DefaultClimate { get; set; } = default!;

    [JsonPropertyName("isUseDefault")]
    public bool IsUseDefault { get; set; }

    [JsonPropertyName("sceneID")]
    public int SceneID { get; set; }
}
