namespace Snap.Data.Mapper.Model.ExcelBinOutput.Hunting;

public class HuntingRefreshExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("regionId")]
    public int RegionId { get; set; }

    [JsonPropertyName("finishRewardId")]
    public int FinishRewardId { get; set; }

    [JsonPropertyName("difficulty")]
    public string Difficulty { get; set; } = default!;
}