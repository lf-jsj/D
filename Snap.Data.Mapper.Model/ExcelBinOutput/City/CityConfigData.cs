namespace Snap.Data.Mapper.Model.ExcelBinOutput.City;
public class CityConfigData : DataObject
{
    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("areaIdVec")]
    public IList<int> AreaIdVec { get; set; } = default!;

    [JsonPropertyName("cityNameTextMapHash")]
    public Text CityNameTextMapHash { get; set; }

    [JsonPropertyName("mapPosX")]
    public int MapPosX { get; set; }

    [JsonPropertyName("mapPosY")]
    public int MapPosY { get; set; }

    [JsonPropertyName("zoomForExploration")]
    public double ZoomForExploration { get; set; }

    [JsonPropertyName("adventurePointId")]
    public int AdventurePointId { get; set; }

    [JsonPropertyName("ExpeditionMap")]
    public string ExpeditionMap { get; set; } = default!;

    [JsonPropertyName("ExpeditionWaterMark")]
    public string ExpeditionWaterMark { get; set; } = default!;

    [JsonPropertyName("openState")]
    public string OpenState { get; set; } = default!;

    [JsonPropertyName("cityGoddnessNameTextMapHash")]
    public Text CityGoddnessNameTextMapHash { get; set; }

    [JsonPropertyName("cityGoddnessDescTextMapHash")]
    public Text CityGoddnessDescTextMapHash { get; set; }
}
