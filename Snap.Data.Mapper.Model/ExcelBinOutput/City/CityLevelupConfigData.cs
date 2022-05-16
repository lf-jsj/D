namespace Snap.Data.Mapper.Model.ExcelBinOutput.City;

public class CityLevelupConfigData : DataObject
{
    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("consumeItem")]
    public ConsumeItem ConsumeItem { get; set; } = default!;

    [JsonPropertyName("rewardID")]
    public int RewardID { get; set; }

    [JsonPropertyName("actionVec")]
    public IList<ActionVec> ActionVec { get; set; } = default!;
}
